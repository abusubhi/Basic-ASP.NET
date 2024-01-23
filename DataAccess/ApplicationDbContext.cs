using BasicsAPI.Models;
using Microsoft.EntityFrameworkCore;
using Model.DTOs;
using System;
using System.Collections.Generic;

namespace DataAccess.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            

            modelBuilder.Entity<ReqEmployeeDTO>().HasNoKey();

            base.OnModelCreating(modelBuilder);
        }
        public DbSet<ReqEmployeeDTO> EmployeesDTO { get; set; }
        public DbSet<Employee> Employees { get; set; }



    }

}
