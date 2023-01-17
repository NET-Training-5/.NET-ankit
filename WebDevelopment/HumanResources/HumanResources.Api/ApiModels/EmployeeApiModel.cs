using HumanResources.ApplicationCore.Enums;

namespace HumanResources.Web.ViewModels;
public class EmployeeApiModel
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string? Address { get; set; }
    public string Email { get; set; }
    public Gender Gender { get; set; }
    public DateTime? Dob { get; set; }
    public DateTime JoinDate { get; set; }
    public string Designation { get; set; }
    public IFormFile ProfileImage { get; set; }
    public string? ProfileImagePath { get; set; }
    public string? DepartmentName { get; set; }
    public int DepartmentId { get; set; } 
}
