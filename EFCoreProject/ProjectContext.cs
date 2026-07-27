using EFCoreProject.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace EFCoreProject
{
    public class ProjectContext : DbContext //oop inhertance 
    {
        //1- register models
        public DbSet<Employee> employees {  get; set; }
        public DbSet<Department> department { get; set; }
        public DbSet<Project> project { get; set;  }
        public DbSet<Dependent> dependent { get; set; }
        public DbSet<DeptLocation> deptLocations { get; set; }
        public DbSet<WorksOnEmpProj> worksOnEmpProjs { get; set; }




        //2- connect to database
        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlServer(
            "Server=(localdb)\\MSSQLLocalDB;Database=CompanyProjectDB;Trusted_Connection=True;TrustServerCertificate=True;"
            );
        }




    }
}
