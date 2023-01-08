using HumanResources.Web.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System.Runtime.InteropServices;

namespace HumanResources.Web.Controllers
{
    public class EmployeeController : Controller
    {
        HRDbContext db = new HRDbContext();
        public async Task< IActionResult> Index()
        {

            var employees = await db.Employees.Include(d => d.Designation).ToListAsync();
            var employeees =await db.Employees.Include(e => e.Department).ToListAsync();

            return View(employees);
        }

       

        public async Task<IActionResult> Add()
        {
            var departments = await db.Departments.Select(department => new SelectListItem
            {
                Text = department.Name,
                Value = department.Id.ToString()
            }).ToListAsync();
            ViewData["departments"] = departments;

            var designations = db.Designations.Select(designation => new SelectListItem
            {
                Text = designation.Name,
                Value = designation.Id.ToString()
            }).ToList();
            ViewData["designations"] = designations;

            return View();
        }



        [HttpPost]
        public async Task<IActionResult> Add(Employee employee)
        {

            await db.Employees.AddAsync(employee);
            await db.SaveChangesAsync();
            return RedirectToAction("Index");
        }

        public async Task<IActionResult> Edit(int id)
        {
            var employee = await db.Employees.FindAsync(id);
            return View(employee);
        }
        [HttpPost]
        public IActionResult Edit(Employee employee)
        {

            db.Employees.Update(employee);
            db.SaveChanges();

            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> Delete(int id)
        {
            var employee = await db.Employees.FindAsync(id);
            return View(employee);
        }
        [HttpPost]
        public IActionResult Delete(Employee employee)
        {

            db.Employees.Remove(employee);
            db.SaveChanges();

            return RedirectToAction(nameof(Index));
        }

    }

}
