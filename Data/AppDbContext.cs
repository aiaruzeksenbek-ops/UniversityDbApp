using Microsoft.EntityFrameworkCore;
using UniversityDbApp.Models;

namespace UniversityDbApp.Data;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options)
        : base(options)
    {
    }

    public DbSet<Department> Departments => Set<Department>();

    public DbSet<Teacher> Teachers => Set<Teacher>();
}