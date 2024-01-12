using API_Database.Data;
using API_Database.Services.Students;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args); 

// The first builder is accessing DbContext, the background data for our Database, and our DataContext file to set the Connection string
// The second builder is accessing our web apps configuration settings, or appsettings.json, and getting our connection string
// Letting our DataContext file know where our Database is
builder.Services.AddDbContext<DataContext>(options =>
    options.UseSqlite(builder.Configuration.GetConnectionString("DatabaseConnection"))
);

builder.Services.AddControllers(); 
builder.Services.AddEndpointsApiExplorer(); 
builder.Services.AddSwaggerGen(); 
builder.Services.AddScoped<IStudentService, StudentService>(); 

var app = builder.Build(); 


if (app.Environment.IsDevelopment()) 
{
    app.UseSwagger();
    app.UseSwaggerUI();
}


app.UseAuthorization();
app.MapControllers();
app.Run(); 
