﻿using EcommerceProject.Models;
using Microsoft.EntityFrameworkCore;

namespace EcommerceProject.DataAccess.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        //categories is a name of table in the db
        public DbSet<Category> Categories { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>().HasData(
                new Category { Id = 1, Name = "Category 1", DisplayOrder = 1},
                new Category { Id = 2, Name = "Category 2", DisplayOrder = 2 },
                new Category { Id = 3, Name = "Category 3", DisplayOrder = 3 }
                );
        }
    }
}