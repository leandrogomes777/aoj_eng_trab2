using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace AvisaSolution.Models
{
    public class AvisaSolutionContext : DbContext
    {
        public AvisaSolutionContext (DbContextOptions<AvisaSolutionContext> options)
            : base(options)
        {
        }

        public DbSet<AvisaSolution.Models.User> User { get; set; }
    }
}
