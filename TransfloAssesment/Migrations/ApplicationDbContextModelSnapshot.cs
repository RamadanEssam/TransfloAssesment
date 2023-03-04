﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TransfloAssesment.Models;

#nullable disable

namespace TransfloAssesment.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("TransfloAssesment.Models.Driver", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("creationDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("deletedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("firstName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<bool?>("isDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("lastName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<DateTime?>("modificationDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("phoneNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Drivers");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Email = "Ramadan@gmail.com",
                            creationDate = new DateTime(2023, 3, 3, 0, 0, 0, 0, DateTimeKind.Local),
                            firstName = "Ramadan1",
                            isDeleted = false,
                            lastName = "Essam",
                            phoneNumber = "+128987873"
                        },
                        new
                        {
                            Id = 2,
                            Email = "Ramadan2@gmail.com",
                            creationDate = new DateTime(2023, 3, 3, 0, 0, 0, 0, DateTimeKind.Local),
                            firstName = "Ramadan2",
                            isDeleted = false,
                            lastName = "Essam",
                            phoneNumber = "+1028987873"
                        },
                        new
                        {
                            Id = 3,
                            Email = "Ramadan3@gmail.com",
                            creationDate = new DateTime(2023, 3, 3, 0, 0, 0, 0, DateTimeKind.Local),
                            firstName = "Ramadan3",
                            isDeleted = false,
                            lastName = "Essam",
                            phoneNumber = "+01028987873"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
