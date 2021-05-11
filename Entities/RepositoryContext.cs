using Entities.Models;
using Microsoft.EntityFrameworkCore;
using System;

namespace Entities
{
    public class RepositoryContext : DbContext
    {
        public RepositoryContext(DbContextOptions options)
            : base(options)
        {
        }

        public DbSet<User> Users { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().HasData(new User
            {
                Id = 1,
                Name = "Administrator",
                Phone = "087872240337",
                Email = "yoga.xv@gmail.com",
                VerifiedAt = DateTime.Now,
                Password  = "admin",
                CreatedAt = DateTime.Now,
                UpdatedAt = DateTime.Now

            }, new User
            {
                Id = 2,
                Name = "Second Admin",
                Phone = "087872240336",
                Email = "yoshikun.21@gmail.com",
                VerifiedAt = DateTime.Now,
                Password = "admin",
                CreatedAt = DateTime.Now,
                UpdatedAt = DateTime.Now
            });
        }
    }
}