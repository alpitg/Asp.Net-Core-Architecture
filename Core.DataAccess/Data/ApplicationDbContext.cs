using Core.DataAccess.DbEntities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.DataAccess.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {
        }
        public DbSet<EmployeeDetail> EmployeeDetail { get; set; }
        public DbSet<EmployeeAttendance> EmployeeAttendance { get; set; }



        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //modelBuilder.Entity<EmployeeAttendance>().HasKey(x => new { x.EmployeeDetailId });
            modelBuilder.Entity<EmployeeAttendance>().HasKey(x => x.EmployeeDetailId);
        }
    }
}