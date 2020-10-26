using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using GitExample.Models;

namespace GitExample.Data
{
    public class GitExampleContext : DbContext
    {
        public GitExampleContext (DbContextOptions<GitExampleContext> options)
            : base(options)
        {
        }

        public DbSet<GitExample.Models.Product> Product { get; set; }
    }
}
