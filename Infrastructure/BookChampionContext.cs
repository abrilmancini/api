using System;
using Microsoft.EntityFrameworkCore;
using Domain.Entities;

namespace Infrastructure;

public class BookChampionContext : DbContext
{
    public BookChampionContext(DbContextOptions<BookChampionContext> options) : base(options)
    {
    }

    public DbSet<User> Users { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        
        // Configure User entity
        modelBuilder.Entity<User>(entity =>
        {
            entity.HasKey(e => e.Id);
            entity.Property(e => e.Name).IsRequired().HasMaxLength(100);
            entity.Property(e => e.Email).IsRequired().HasMaxLength(100);
        });
    }
}