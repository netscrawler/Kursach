using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kursach
{
    public class Ctx: DbContext
    {
        private string _connectionString;

        public Ctx(string connectionString = "Host=localhost; Database=KursachDB; Username=postgres; Password=0000")
        {
            _connectionString = connectionString;
        }

        public DbSet<Cabinet> cabinets { get; set; }
        public DbSet<Disease> diseases { get; set; }
        public DbSet<Pacient> pacients { get; set; }
        public DbSet<Procedure> procedures { get; set; }
        public DbSet<Procedure_Card> procedure_Cards { get; set; }
        public DbSet<Procedures_History> procedures_Histories { get; set; }
        public DbSet<Admin> admins { get; set; }
        public DbSet<Doctor> doctors { get; set; }
        public DbSet<Nurse> nurses { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseNpgsql(_connectionString);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Restaurant_hall>()
                .HasOne(e => e.Waiter_s_schedule)
                .WithOne(e => e.Restaurant_hall)
                .HasForeignKey<Waiter_s_schedule>(e => e.Restaurant_hallid)
                .IsRequired();
        }
    }
}
}
