
using HumanResources.Web.enums;
using System.ComponentModel.DataAnnotations;

namespace HumanResources.Web.Models;
public class Designation
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public Role Role { get; set; } = Role.Developer;

    public List<Employee>? Employees { get; set; }
}
