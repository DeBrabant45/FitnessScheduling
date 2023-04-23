using Domain.Routine;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using Persistence.Routines;
using Persistence.Workouts;

namespace Persistence;

public class DatabaseService : DbContext
{
    private readonly IConfiguration _configuration;

    public DatabaseService(IConfiguration configuration)
    {
        _configuration = configuration;
        Database.EnsureCreated();
    }

    public DbSet<Routine> Routines { get; set; }
    public DbSet<Workout> Workouts { get; set; }

    public void Save()
    {
        SaveChanges();
    }

    public void SaveAsync()
    {
        SaveChangesAsync();
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        var connectionString = _configuration.GetConnectionString("FitnessSchedule");

        optionsBuilder.UseSqlServer(connectionString);
    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);

        new RoutineConfiguration().Configure(builder.Entity<Routine>());
        new WorkoutsConfiguration().Configure(builder.Entity<Workout>());
    }
}