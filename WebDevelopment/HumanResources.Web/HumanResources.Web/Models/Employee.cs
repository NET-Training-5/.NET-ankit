
using HumanResources.Web.enums;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HumanResources.Web.Models
{
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string? Address { get; set; }

        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        public Gender Gender { get; set; }
        public DateTime? Dob { get; set; }
        public DateTime JoinDate { get; set; }
        public Designation Designation { get; set; }
        public int DesignationId { get; set; }

        [NotMapped]
        public IFormFile ProfileImage { get; set; }
        public string ProfileImagePath { get; set; }

        public Department Department { get; set; }
        public int DepartmentId { get; set; }

     
    }
}
