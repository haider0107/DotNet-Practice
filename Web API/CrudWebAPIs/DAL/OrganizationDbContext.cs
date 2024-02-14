using Microsoft.EntityFrameworkCore;
using SelectInDepth.BOL.DataModel;
using SelectInDepth.BOL.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SelectInDepth.DAL
{
    public class OrganizationDbContext : DbContext
    {
        public DbSet<Department>? Departments { get; set; }
        public DbSet<Employee>? Employees { get; set; }
        public DbSet<Project>? Projects { get; set; }
        public DbSet<Module>? Modules { get; set; }
        public DbSet<SelectInDepth.BOL.DataModel.Task>? Tasks { get; set; }
        public DbSet<EmpDetail>? EmpDetails { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            //optionsBuilder.UseLazyLoadingProxies();
            optionsBuilder.UseSqlServer("Server=DESKTOP-MSQQ9TJ\\SQLEXPRESS01;Database=SelectOrgEFDb;Trusted_Connection=True;");
        }
    }
}
