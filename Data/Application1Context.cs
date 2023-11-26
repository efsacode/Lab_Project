using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Application1.Models;

namespace Application1.Data
{
    public class Application1Context : DbContext
    {
        public Application1Context (DbContextOptions<Application1Context> options)
            : base(options)
        {
        }

        public DbSet<Application1.Models.Employee> Employee { get; set; } = default!;
    }
}
