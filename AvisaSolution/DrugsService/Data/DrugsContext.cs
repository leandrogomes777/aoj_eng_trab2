using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using DrugsService.Model;
using System.IO;

namespace DrugsService.Models
{
    public class DrugsContext : DbContext
    {
        public DrugsContext(DbContextOptions<DrugsContext> options)
            : base(options)
        {
            
        }

        public DbSet<DrugsService.Model.Drug> Drug { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Drug>()
                .Property(p => p.ID)
                .ValueGeneratedOnAdd();

            modelBuilder.Entity<Drug>()
                         .ToTable("Drug");

            string[] lines = File.ReadAllLines("lista_a.csv");
            foreach (string line in lines)
            {
                string[] data = line.Split(',', StringSplitOptions.RemoveEmptyEntries);

                if (data.Length < 7)
                    continue;  

                modelBuilder.Entity<Drug>()
                    .HasData(new Drug()
                    {
                        DrugName = data[0],
                        Holder = data[1],
                        Medicine = data[2],
                        Record = data[3],
                        Concentration = data[4],
                        PharmaceuticalForm = data[5],
                    });

            }
        }
    }
}
