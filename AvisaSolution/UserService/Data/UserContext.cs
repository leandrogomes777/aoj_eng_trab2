using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace AvisaSolution.Models
{
    public class UserContext : DbContext
    {
        public UserContext (DbContextOptions<UserContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>()
                .ToTable("User");

            modelBuilder.Entity<User>()
                .HasData(
                    new User
                    {
                        //ID = 1,
                        Name = "Leandro",
                        LastName = "Gomes",
                        Password = "123456"
                    },
                    new User
                    {
                        //ID = 2,
                        Name = "Fabio",
                        LastName = "Massamitsu",
                        Password = "123456"
                    },
                    new User
                    {
                        //ID = 3,
                        Name = "Deryk  ",
                        LastName = "",
                        Password = "123456"
                    }
                );
        }

        public DbSet<AvisaSolution.Models.User> User { get; set; }


    }
}
