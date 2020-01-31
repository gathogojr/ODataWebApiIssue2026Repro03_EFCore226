﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ODataWebApiIssue2026Repro03_EFCore226.DataSources;

namespace ODataWebApiIssue2026Repro03_EFCore226.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20200131062958_InitialMigration")]
    partial class InitialMigration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.0-rtm-35687")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("ODataWebApiIssue2026Repro03_EFCore226.Models.Department", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("Departments");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "IT"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Marketing"
                        });
                });

            modelBuilder.Entity("ODataWebApiIssue2026Repro03_EFCore226.Models.Employee", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("DepartmentId");

                    b.Property<int>("EmployerId");

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.HasIndex("DepartmentId");

                    b.HasIndex("EmployerId");

                    b.ToTable("Employees");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            DepartmentId = 1,
                            EmployerId = 1,
                            Name = "Janiya Rich"
                        },
                        new
                        {
                            Id = 2,
                            DepartmentId = 2,
                            EmployerId = 1,
                            Name = "Lailah Morgan"
                        },
                        new
                        {
                            Id = 3,
                            DepartmentId = 2,
                            EmployerId = 1,
                            Name = "Aden Salas"
                        },
                        new
                        {
                            Id = 4,
                            DepartmentId = 1,
                            EmployerId = 1,
                            Name = "Clark Knight"
                        },
                        new
                        {
                            Id = 5,
                            DepartmentId = 1,
                            EmployerId = 1,
                            Name = "Miya Hardin"
                        },
                        new
                        {
                            Id = 6,
                            DepartmentId = 2,
                            EmployerId = 2,
                            Name = "Johnny Stuart"
                        },
                        new
                        {
                            Id = 7,
                            DepartmentId = 1,
                            EmployerId = 2,
                            Name = "Cloe Nolan"
                        },
                        new
                        {
                            Id = 8,
                            DepartmentId = 1,
                            EmployerId = 2,
                            Name = "Diana Vargas"
                        },
                        new
                        {
                            Id = 9,
                            DepartmentId = 2,
                            EmployerId = 2,
                            Name = "Leroy Byrd"
                        });
                });

            modelBuilder.Entity("ODataWebApiIssue2026Repro03_EFCore226.Models.Employer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("Employers");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Gabriela Barron"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Gavyn Navarro"
                        });
                });

            modelBuilder.Entity("ODataWebApiIssue2026Repro03_EFCore226.Models.Employee", b =>
                {
                    b.HasOne("ODataWebApiIssue2026Repro03_EFCore226.Models.Department", "Department")
                        .WithMany()
                        .HasForeignKey("DepartmentId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("ODataWebApiIssue2026Repro03_EFCore226.Models.Employer", "Employer")
                        .WithMany("Employees")
                        .HasForeignKey("EmployerId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}