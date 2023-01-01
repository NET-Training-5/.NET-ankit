using HumanResources.Web.Models;
using Microsoft.EntityFrameworkCore;
public class HRDbContext : DbContext
{
    public DbSet<Employee> Employees { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer("Data Source=(localdb)\\ProjectModels;Initial Catalog=HumanResources_Test;"
             + "Integrated Security=true");

    }
}