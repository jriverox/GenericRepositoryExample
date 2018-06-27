using GenericRepositoryExample.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace GenericRepositoryExample.Data.EF
{
    public class AppDbContext: DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options):base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().ToTable("User");
            modelBuilder.Entity<Department>().ToTable("Department");
        }
        public DbSet<User> Users { get; set; }

        public DbSet<Department> Departments { get; set; }
    }
}
