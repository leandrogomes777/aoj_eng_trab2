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
                        ID = 1,
                        Email = "leandro@avisa.com.br",
                        Name = "Leandro",
                        LastName = "Gomes",
                        Password = "123456"
                    },
                    new User
                    {
                        ID = 2,
                        Email = "fabio@avisa.com.br",
                        Name = "Fabio",
                        LastName = "Massamitsu",
                        Password = "123456"
                    },
                    new User
                    {
                        ID = 3,
                        Email = "deryk@avisa.com.br",
                        Name = "Deryk  ",
                        LastName = "",
                        Password = "123456"
                    }
                );
        }

        public DbSet<AvisaSolution.Models.User> User { get; set; }


    }
}
