using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using TrashCollectionRiches.Models;
using TrashCollectionRiches.Views.ViewModels;

namespace TrashCollectionRiches.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<IdentityRole>()
                .HasData(
                     new IdentityRole
                     {
                         Name = "Customer",
                         NormalizedName = "CUSTOMER"
                     },
                      new IdentityRole
                      {
                          Name = "Employee",
                          NormalizedName = "EMPLOYEE"
                      }
                );

        }

        public DbSet<TrashCollectionRiches.Models.Customer> Customer { get; set; }
        public DbSet<TrashCollectionRiches.Models.Employee> Employee { get; set; }

    }
}
