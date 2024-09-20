using Kursach.Roles;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kursach
{
    public class Ctx : DbContext
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

            modelBuilder.Entity<Procedure>(entity =>
            {
                entity.HasKey(e => e.Id);
                entity.Property(e => e.Name).IsRequired();
                entity.Property(e => e.Length).IsRequired();
            });

            // Настройка модели для класса Cabinet
            modelBuilder.Entity<Cabinet>(entity =>
            {
                entity.HasKey(e => e.Id);
                entity.Property(e => e.Number).IsRequired();
                entity.Property(e => e.Open).IsRequired();
                entity.Property(e => e.Close).IsRequired();
                entity.Property(e => e.Weekend).IsRequired();
            });
            modelBuilder.Entity<Disease>(entity =>
            {
                entity.HasKey(e => e.Id);
                entity.Property(e => e.Name).IsRequired();
                entity.HasMany(e => e.Procedures).WithMany();
            });
            modelBuilder.Entity<User>(entity =>
            {
                entity.HasKey(e => e.Id);
                entity.HasOne(u => u.Admin)
                    .WithOne(a => a.User)
                    .HasForeignKey<Admin>(a => a.Id);
                entity.HasOne(u => u.Doctor)
                    .WithOne(d => d.User)
                    .HasForeignKey<Doctor>(d => d.Id);
                entity.HasOne(u => u.Nurse)
                    .WithOne(n => n.User)
                    .HasForeignKey<Nurse>(n => n.Id);
            });
            modelBuilder.Entity<Doctor>(entity =>
            {
                entity.HasKey(e => e.Id);
                entity.Property(e => e.Name).IsRequired();
                entity.Property(e => e.Surname).IsRequired();
                entity.Property(e => e.LastName).IsRequired();
                entity.Property(e => e.Birthday).IsRequired();
                entity.Property(e => e.Email).IsRequired();
                entity.Property(e => e.Snils).IsRequired();
                entity.Property(e => e.Phone).IsRequired();
                entity.HasOne(e => e.User).WithOne().IsRequired();
            });
            modelBuilder.Entity<Nurse>(entity =>
            {
                entity.HasKey(e => e.Id);
                entity.Property(e => e.Name).IsRequired();
                entity.Property(e => e.Surname).IsRequired();
                entity.Property(e => e.LastName).IsRequired();
                entity.Property(e => e.Birthday).IsRequired();
                entity.Property(e => e.Email).IsRequired();
                entity.Property(e => e.Snils).IsRequired();
                entity.Property(e => e.Phone).IsRequired();
                entity.HasOne(e => e.User).WithOne().IsRequired();
            });
            modelBuilder.Entity<Admin>(entity =>
            {
                entity.HasKey(e => e.Id);
                entity.Property(e => e.Name).IsRequired();
                entity.Property(e => e.Surname).IsRequired();
                entity.Property(e => e.LastName).IsRequired();
                entity.Property(e => e.Birthday).IsRequired();
                entity.Property(e => e.Email).IsRequired();
                entity.Property(e => e.Snils).IsRequired();
                entity.Property(e => e.Phone).IsRequired();
                entity.HasOne(e => e.User).WithOne().IsRequired();
            });
            modelBuilder.Entity<Pacient>(entity =>
            {
                entity.HasKey(e => e.Id);
                entity.Property(e => e.Name).IsRequired();
                entity.Property(e => e.Surname).IsRequired();
                entity.Property(e => e.LastName).IsRequired();
                entity.Property(e => e.Birthday).IsRequired();
                entity.Property(e => e.Email).IsRequired();
                entity.Property(e => e.Snils).IsRequired();
                entity.Property(e => e.Phone).IsRequired();
                entity.HasMany(e => e.Procedure_Cards).WithOne().IsRequired();
            });
            modelBuilder.Entity<Procedure_Card>(entity =>
            {
                entity.HasKey(e => e.Id);
                entity.Property(e => e.Zhalobi).IsRequired();
                entity.HasMany(e => e.Diseases).WithMany();
                entity.HasMany(e => e.Procedures_History).WithOne(e => e.Card).IsRequired();
                entity.HasOne(e => e.Pacient).WithMany(e => e.Procedure_Cards).IsRequired();
                entity.HasOne(e => e.Doctor).WithMany().IsRequired();
            });

            // Настройка модели для класса Procedures_History
            modelBuilder.Entity<Procedures_History>(entity =>
            {
                entity.HasKey(e => e.Id);
                entity.Property(e => e.Date).IsRequired();
                entity.HasMany(e => e.Procedures).WithMany();
                entity.HasOne(e => e.Card).WithMany(e => e.Procedures_History).IsRequired();
            });
            base.OnModelCreating(modelBuilder);


        }
    }
}
