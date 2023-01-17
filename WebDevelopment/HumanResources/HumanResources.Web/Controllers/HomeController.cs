using HumanResources.ApplicationCore.Enums;
using HumanResources.Web.Models;
using Microsoft.AspNetCore.Mvc;
using System.Data.SqlClient;
using System.Diagnostics;

namespace HumanResources.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            List<Employee> employees = new List<Employee>();

            // Fetch data from db
            string connectionString = @"Data Source=(localdb)\mssqllocaldb;Initial Catalog=HumanResources_Test;Integrated Security=true";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand("Select * from Employee", connection);

                try
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        var emp = new Employee
                        {
                            Id = reader.GetInt32(0),
                            Name = reader.GetString(1),
                            Address = reader.GetString(2),
                            Gender = (Gender)reader.GetInt32(3),
                            Dob = reader.GetDateTime(4),
                        };

                        employees.Add(emp);
                    }
                    reader.Close();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }

            return View(employees);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}