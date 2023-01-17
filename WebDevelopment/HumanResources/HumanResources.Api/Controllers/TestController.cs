using HumanResources.Web.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace HumanResources.Api.Controllers
{
    [Route("api/test")]
    [ApiController]
    public class TestController : ControllerBase
    {
        [Route("hello")]
        public string Hello()
        {
            return "Hello World!";
        }
        [Route("greets")]
        public string[] Greet()
        {
            string[] greets= {"Hello","Hi","Namaste"};
            return greets;
        }
        [Route("departments")]
        public Department[] GetDepartments()
        {
            Department department1 = new Department { Name = "R&D", Estalbished = DateTime.Now };
            Department department2 = new Department { Name = "Operations", Estalbished = DateTime.Now };
            return new Department[] { department1, department2 };
        }
            

    }
}

