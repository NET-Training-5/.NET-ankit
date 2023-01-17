
using HumanResources.Web.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

public class HRDbContext:IdentityDbContext<IdentityUser>
{
    public DbSet<Employee> Employees { get; set; }
    public DbSet<Department> Departments { get; set; }
    public DbSet<Designation> Designations { get; set; }

    public HRDbContext(DbContextOptions<HRDbContext> options): base(options)
    {        
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer("Data Source=(localdb)\\ProjectModels;Initial Catalog=HumanResources_Test;"
             + "Integrated Security=true");

    }
}
