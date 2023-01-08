using Microsoft.AspNetCore.Mvc;

public class EmployeeController : Controller
{
    public IActionResult Detail()
    {


        Employee e1 = new Employee()
        {
            FullName = "Ankit Dhungana",
            Sex = Gender.Male,
            JoinDate = new DateTime(2011, 7, 12),
            Designation = "Engineer",
            Department = "IT",
        };
        Employee e2 = new Employee()
        {
            FullName = "Ram Dhungana",
            Sex = Gender.Male,
            JoinDate = new DateTime(2015, 8, 22),
            Designation = "SOft.Engineer",
            Department = "IT Department",
        };


        List<Employee> employees = new List<Employee>(){e1,e2};
        
        return View(employees);
    }
}
