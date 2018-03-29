using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace VoltageWebApi.Models
{
    public class VoltageContext : DbContext
    {
        public VoltageContext(DbContextOptions<VoltageContext> options) : base(options)
        {

        }

        public DbSet<TodoItem> TodoItems { get; set; }
    }
}
