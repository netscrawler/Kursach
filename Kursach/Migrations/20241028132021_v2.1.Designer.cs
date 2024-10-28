﻿// <auto-generated />
using System;
using Kursach;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace Kursach.Migrations
{
    [DbContext(typeof(Ctx))]
    [Migration("20241028132021_v2.1")]
    partial class v21
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.17")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("Kursach.Admin", b =>
                {
                    b.Property<Guid>("Id")
                        .HasColumnType("uuid");

                    b.Property<DateOnly>("Birthday")
                        .HasColumnType("date");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<decimal>("Phone")
                        .HasColumnType("numeric(20,0)");

                    b.Property<decimal>("Snils")
                        .HasColumnType("numeric(20,0)");

                    b.Property<string>("Surname")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("UserId")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.ToTable("admins");
                });

            modelBuilder.Entity("Kursach.Cabinet", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<TimeOnly>("Close")
                        .HasColumnType("time without time zone");

                    b.Property<string>("Number")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<TimeOnly>("Open")
                        .HasColumnType("time without time zone");

                    b.Property<string>("Weekend")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("cabinets");
                });

            modelBuilder.Entity("Kursach.Doctor", b =>
                {
                    b.Property<Guid>("Id")
                        .HasColumnType("uuid");

                    b.Property<DateOnly>("Birthday")
                        .HasColumnType("date");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<decimal>("Phone")
                        .HasColumnType("numeric(20,0)");

                    b.Property<decimal>("Snils")
                        .HasColumnType("numeric(20,0)");

                    b.Property<string>("Surname")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("UserId")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.ToTable("doctors");
                });

            modelBuilder.Entity("Kursach.Nurse", b =>
                {
                    b.Property<Guid>("Id")
                        .HasColumnType("uuid");

                    b.Property<DateOnly>("Birthday")
                        .HasColumnType("date");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<decimal>("Phone")
                        .HasColumnType("numeric(20,0)");

                    b.Property<decimal>("Snils")
                        .HasColumnType("numeric(20,0)");

                    b.Property<string>("Surname")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uuid");

                    b.HasKey("Id");

                    b.HasIndex("UserId")
                        .IsUnique();

                    b.ToTable("nurses");
                });

            modelBuilder.Entity("Kursach.Pacient", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<DateOnly>("Birthday")
                        .HasColumnType("date");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<decimal>("Phone")
                        .HasColumnType("numeric(20,0)");

                    b.Property<decimal>("Snils")
                        .HasColumnType("numeric(20,0)");

                    b.Property<string>("Surname")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("pacients");
                });

            modelBuilder.Entity("Kursach.Procedure", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<TimeOnly>("Length")
                        .HasColumnType("time without time zone");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<Guid?>("Procedure_CardId")
                        .HasColumnType("uuid");

                    b.HasKey("Id");

                    b.HasIndex("Procedure_CardId");

                    b.ToTable("procedures");
                });

            modelBuilder.Entity("Kursach.Procedure_Card", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<string[]>("Diseases")
                        .IsRequired()
                        .HasColumnType("text[]");

                    b.Property<Guid>("DoctorId")
                        .HasColumnType("uuid");

                    b.Property<Guid>("PacientId")
                        .HasColumnType("uuid");

                    b.Property<string[]>("Zhalobi")
                        .IsRequired()
                        .HasColumnType("text[]");

                    b.HasKey("Id");

                    b.HasIndex("DoctorId");

                    b.HasIndex("PacientId");

                    b.ToTable("procedurecards");
                });

            modelBuilder.Entity("Kursach.Procedures_History", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<Guid>("CardId")
                        .HasColumnType("uuid");

                    b.Property<DateTime>("Date")
                        .HasColumnType("timestamp with time zone");

                    b.HasKey("Id");

                    b.HasIndex("CardId");

                    b.ToTable("procedureshistories");
                });

            modelBuilder.Entity("Kursach.User", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<Guid?>("AdminId")
                        .HasColumnType("uuid");

                    b.Property<Guid?>("DoctorId")
                        .HasColumnType("uuid");

                    b.Property<string>("Login")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<byte[]>("Password")
                        .IsRequired()
                        .HasColumnType("bytea");

                    b.HasKey("Id");

                    b.HasIndex("AdminId");

                    b.HasIndex("DoctorId");

                    b.ToTable("users");
                });

            modelBuilder.Entity("ProcedureProcedures_History", b =>
                {
                    b.Property<Guid>("ProceduresId")
                        .HasColumnType("uuid");

                    b.Property<Guid>("Procedures_HistoryId")
                        .HasColumnType("uuid");

                    b.HasKey("ProceduresId", "Procedures_HistoryId");

                    b.HasIndex("Procedures_HistoryId");

                    b.ToTable("ProcedureProcedures_History");
                });

            modelBuilder.Entity("Kursach.Admin", b =>
                {
                    b.HasOne("Kursach.User", "User")
                        .WithOne()
                        .HasForeignKey("Kursach.Admin", "Id");

                    b.Navigation("User");
                });

            modelBuilder.Entity("Kursach.Doctor", b =>
                {
                    b.HasOne("Kursach.User", "User")
                        .WithOne()
                        .HasForeignKey("Kursach.Doctor", "Id");

                    b.Navigation("User");
                });

            modelBuilder.Entity("Kursach.Nurse", b =>
                {
                    b.HasOne("Kursach.User", "User")
                        .WithOne()
                        .HasForeignKey("Kursach.Nurse", "Id");

                    b.HasOne("Kursach.User", null)
                        .WithOne("Nurse")
                        .HasForeignKey("Kursach.Nurse", "UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("Kursach.Procedure", b =>
                {
                    b.HasOne("Kursach.Procedure_Card", null)
                        .WithMany("Procedures")
                        .HasForeignKey("Procedure_CardId");
                });

            modelBuilder.Entity("Kursach.Procedure_Card", b =>
                {
                    b.HasOne("Kursach.Doctor", "Doctor")
                        .WithMany()
                        .HasForeignKey("DoctorId");

                    b.HasOne("Kursach.Pacient", "Pacient")
                        .WithMany("ProcedureCards")
                        .HasForeignKey("PacientId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Doctor");

                    b.Navigation("Pacient");
                });

            modelBuilder.Entity("Kursach.Procedures_History", b =>
                {
                    b.HasOne("Kursach.Procedure_Card", "Card")
                        .WithMany("Procedures_History")
                        .HasForeignKey("CardId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Card");
                });

            modelBuilder.Entity("Kursach.User", b =>
                {
                    b.HasOne("Kursach.Admin", "Admin")
                        .WithMany()
                        .HasForeignKey("AdminId");

                    b.HasOne("Kursach.Doctor", "Doctor")
                        .WithMany()
                        .HasForeignKey("DoctorId");

                    b.Navigation("Admin");

                    b.Navigation("Doctor");
                });

            modelBuilder.Entity("ProcedureProcedures_History", b =>
                {
                    b.HasOne("Kursach.Procedure", null)
                        .WithMany()
                        .HasForeignKey("ProceduresId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Kursach.Procedures_History", null)
                        .WithMany()
                        .HasForeignKey("Procedures_HistoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Kursach.Pacient", b =>
                {
                    b.Navigation("ProcedureCards");
                });

            modelBuilder.Entity("Kursach.Procedure_Card", b =>
                {
                    b.Navigation("Procedures");

                    b.Navigation("Procedures_History");
                });

            modelBuilder.Entity("Kursach.User", b =>
                {
                    b.Navigation("Nurse");
                });
#pragma warning restore 612, 618
        }
    }
}
