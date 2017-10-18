using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Lab27George.Models
{
    public class Lab27GeorgeContext : DbContext
    {
        public Lab27GeorgeContext (DbContextOptions<Lab27GeorgeContext> options)
            : base(options)
        {
        }

        public DbSet<Lab27George.Models.Player> Player { get; set; }
    }
}
