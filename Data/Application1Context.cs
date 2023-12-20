using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Application1.Models;
using Microsoft.Extensions.Hosting;
using System.Reflection.Metadata;

namespace Application1.Data
{
    public class Application1Context : DbContext
    {
        public Application1Context (DbContextOptions<Application1Context> options)
            : base(options)
        {
        }

        public DbSet<Application1.Models.Employee> Employee { get; set; } = default!;
        public DbSet<Application1.Models.Company> Company{ get; set; }

        public DbSet<Application1.Models.SalaryInfo> SalaryInfo { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Company>();

           modelBuilder.Entity<SalaryInfo>();
            /*     .HasOne(e => e.Employee)
                .WithOne(e => e.SalaryInfo)
                .HasForeignKey<SalaryInfo>(e => e.EmployeeId)
                .IsRequired(); */

            modelBuilder.Entity<Employee>();
           /*   .HasOne(e => e.SalaryInfo)
              .WithOne(e => e.Employee)
              .HasForeignKey<SalaryInfo>(e => e.EmployeeId)
              .IsRequired();*/

        }
    }
}
