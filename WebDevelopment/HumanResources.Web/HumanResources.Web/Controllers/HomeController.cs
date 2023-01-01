using HumanResources.Web.enums;
using HumanResources.Web.Models;
using Microsoft.AspNetCore.Mvc;
using System.Data.SqlClient;
using System.Data.SqlTypes;
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
            List<Employee> employess = new List<Employee>();
            //Fetch data from db

            string connectionString =
             @"Data Source=(localdb)\ProjectModels;Initial Catalog=HumanResources_Test;"
             + "Integrated Security=true";

            // Provide the query string with a parameter placeholder.
            string queryString =
                "Select * from Employee";

            
            using (SqlConnection connection =
                new SqlConnection(connectionString))
            {
                // Create the Command and Parameter objects.
                SqlCommand command = new SqlCommand(queryString, connection);

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
                            
                            Dob = reader.GetDateTime(4),
                        };
                        employess.Add(emp);
                    };
                   
                    reader.Close();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }



                return View(employess);
            }
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