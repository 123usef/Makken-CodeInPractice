﻿// <auto-generated />
using System;
using MakeenPatch03_Day20.MyDbContext;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace MakeenPatch03_Day20.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("EmployeeProjects", b =>
                {
                    b.Property<int>("EmployeesEmployeeID")
                        .HasColumnType("int");

                    b.Property<int>("projectsId")
                        .HasColumnType("int");

                    b.HasKey("EmployeesEmployeeID", "projectsId");

                    b.HasIndex("projectsId");

                    b.ToTable("EmployeeProjects");
                });

            modelBuilder.Entity("MakeenPatch03_Day20.Models.Department", b =>
                {
                    b.Property<int>("depId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("depId"), 1L, 1);

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Floor")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(80)
                        .HasColumnType("nvarchar(80)");

                    b.Property<long>("PhoneNumber")
                        .HasColumnType("bigint");

                    b.HasKey("depId");

                    b.ToTable("Departments");
                });

            modelBuilder.Entity("MakeenPatch03_Day20.Models.Employee", b =>
                {
                    b.Property<int>("EmployeeID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("EmployeeID"), 1L, 1);

                    b.Property<string>("Adrress")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Age")
                        .HasColumnType("int");

                    b.Property<int?>("DepartmentdepId")
                        .HasColumnType("int");

                    b.Property<int?>("DepartmentdepId1")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Salary")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int?>("deptId")
                        .HasColumnType("int");

                    b.HasKey("EmployeeID");

                    b.HasIndex("DepartmentdepId");

                    b.HasIndex("DepartmentdepId1");

                    b.HasIndex("deptId");

                    b.ToTable("Employees");
                });

            modelBuilder.Entity("MakeenPatch03_Day20.Models.Projects", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Owner")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Projects");
                });

            modelBuilder.Entity("EmployeeProjects", b =>
                {
                    b.HasOne("MakeenPatch03_Day20.Models.Employee", null)
                        .WithMany()
                        .HasForeignKey("EmployeesEmployeeID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MakeenPatch03_Day20.Models.Projects", null)
                        .WithMany()
                        .HasForeignKey("projectsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("MakeenPatch03_Day20.Models.Employee", b =>
                {
                    b.HasOne("MakeenPatch03_Day20.Models.Department", null)
                        .WithMany()
                        .HasForeignKey("DepartmentdepId");

                    b.HasOne("MakeenPatch03_Day20.Models.Department", null)
                        .WithMany()
                        .HasForeignKey("DepartmentdepId1");

                    b.HasOne("MakeenPatch03_Day20.Models.Department", "Department")
                        .WithMany("Employee")
                        .HasForeignKey("deptId");

                    b.Navigation("Department");
                });

            modelBuilder.Entity("MakeenPatch03_Day20.Models.Department", b =>
                {
                    b.Navigation("Employee");
                });
#pragma warning restore 612, 618
        }
    }
}
