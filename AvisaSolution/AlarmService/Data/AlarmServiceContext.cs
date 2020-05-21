using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using AlarmService.Model;

namespace AlarmService.Models
{
    public class AlarmServiceContext : DbContext
    {
        public AlarmServiceContext (DbContextOptions<AlarmServiceContext> options)
            : base(options)
        {
        }

        public DbSet<AlarmService.Model.Alarm> Alarm { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<UserAlarm>()
                .HasKey(bc => new { bc.AlarmId, bc.UserId });
            modelBuilder.Entity<UserAlarm>()
                .HasOne(bc => bc.Alarm)
                .WithMany(b => b.UserAlarms)
                .HasForeignKey(bc => bc.AlarmId);
            modelBuilder.Entity<UserAlarm>()
                .HasOne(bc => bc.User)
                .WithMany(c => c.UserAlarms)
                .HasForeignKey(bc => bc.UserId);
        }
    }
}
