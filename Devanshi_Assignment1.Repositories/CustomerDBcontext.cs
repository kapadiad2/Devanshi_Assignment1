using Devanshi_Assignment1.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Devanshi_Assignment1.Repositories
{
    public class CustomerDBcontext : DbContext
    {
        public CustomerDBcontext(DbContextOptions<CustomerDBcontext> options) : base(options) { }

        public DbSet<customersss> Customers { get; set; }
    }
}
