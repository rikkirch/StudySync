using Microsoft.EntityFrameworkCore;
using StudySync.API.Models;

namespace StudySync.API.Data;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {
    }

    public DbSet<User> Users { get; set; }
    public DbSet<Course> Courses { get; set; }
    public DbSet<StudySession> StudySessions { get; set; }
    public DbSet<Grade> Grades { get; set; }
    public DbSet<Goal> Goals { get; set; }
}