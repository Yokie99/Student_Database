using API_Database.Models;
using Microsoft.EntityFrameworkCore;

namespace API_Database.Data;

public class DataContext : DbContext
{
    // This sets up database functionality on the class
    // DbContextOptions<DataContext> is an EF Core class that allows us to access database configuration settings like the connection string
    public DataContext(DbContextOptions<DataContext> options) : base(options) // the base keyword is allowing us to access stuff from the base or parent class
    {
        
    }

    // Telling our Database to give our Student Model it's own table, or storage container, called Students
    public DbSet<Student> Students { get; set; }
}