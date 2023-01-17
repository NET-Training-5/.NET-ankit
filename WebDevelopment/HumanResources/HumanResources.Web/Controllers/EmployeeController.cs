using HumanResources.Web.Mapper;
using HumanResources.Web.Models;
using HumanResources.Web.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace HumanResources.Web.Controllers;

public class EmployeeController : Controller
{
    private readonly HRDbContext db;

    public EmployeeController(HRDbContext _db)
    {
        db = _db;
    }

    public async Task<IActionResult> Index(string searchText="")
    {
        var employees = await db.Employees.Include(e => e.Department).ToListAsync();
        //filter
        if (!string.IsNullOrEmpty(searchText))
            employees = employees.Where(emp => emp.Name.Contains(searchText, StringComparison.InvariantCultureIgnoreCase)).ToList();


        var employeeViewModels = employees.ToViewModel();

        return View(employeeViewModels);
    }

    public async Task<IActionResult> Add()
    {
        var departments = await db.Departments.Select(department => new SelectListItem
        {
            Text = department.Name,
            Value = department.Id.ToString()
        }).ToListAsync();

        ViewData["departments"] = departments;

        var designations = await db.Designations.Select(designation => new SelectListItem
        {
            Text = designation.Name,
            Value = designation.Name
        }).ToListAsync();

        ViewData["designations"] = designations;

        return View();
    }

    [HttpPost]
    public async Task<IActionResult> Add(EmployeeViewModel employeeViewModel)
    {
        var relativePath = await SaveProfileImage(employeeViewModel.ProfileImage);

        // Map viewmodel to model
        var employee = employeeViewModel.ToModel();
        
        employee.ProfileImagePath = relativePath;
        await db.Employees.AddAsync(employee);
        await db.SaveChangesAsync();

        return RedirectToAction(nameof(Index));
    }

    public IActionResult Edit(int id)
    {
        var employee = db.Employees.Find(id);
        return View(employee);
    }

    [HttpPost]
    public IActionResult Edit(Employee employee)
    {
        db.Employees.Update(employee);
        db.SaveChanges();

        return RedirectToAction(nameof(Index));
    }

    public IActionResult Delete(int id)
    {
        var employee = db.Employees.Find(id);
        return View(employee);
    }

    [HttpPost]
    public IActionResult Delete(Employee employee)
    {
        db.Employees.Remove(employee);
        db.SaveChanges();

        return RedirectToAction(nameof(Index));
    }

    private async Task<string> SaveProfileImage(IFormFile profileImage)
    {        
        var fileName = profileImage.FileName;   //38b7feaa-39d3-4ead-aeeb-ee7dff72cd4a_person.jpg
        var uniqueFileName = $"{Guid.NewGuid()}_{fileName}";
        var relativePath = $"/images/profiles/{uniqueFileName}";
        var currentAppPath = Directory.GetCurrentDirectory();
        var fullFilePath = Path.Combine(currentAppPath, $"wwwroot/{relativePath}");

        var stream = System.IO.File.Create(fullFilePath);
        await profileImage.CopyToAsync(stream);

        return relativePath;
    }
}
