using BeautySalon.Web.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Reflection.Emit;

namespace BeautySalon.Web.Data;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

    public DbSet<Settings> Settings => Set<Settings>();
    public DbSet<Schedule> Schedules => Set<Schedule>();
    public DbSet<Master> Masters => Set<Master>();
    public DbSet<Service> Services => Set<Service>();

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.Entity<Settings>().ToTable("settings");
        modelBuilder.Entity<Schedule>().ToTable("schedules");
        modelBuilder.Entity<Master>().ToTable("masters");
        modelBuilder.Entity<Service>().ToTable("services");
    }
}