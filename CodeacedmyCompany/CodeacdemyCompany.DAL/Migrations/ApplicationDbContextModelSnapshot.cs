﻿// <auto-generated />
using System;
using CodeacdemyCompany.DAL.ApplicationDbContext;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace CodeacdemyCompany.DAL.Migrations
{
    [DbContext(typeof(ApplicationDbContextModelSnapshot))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.26")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("CodeacdemyCompany.DAL.Model.Department", b =>
                {
                    b.Property<int>("IdDepartment")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdDepartment"), 1L, 1);

                    b.Property<string>("Code")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("IdDepartment");

                    b.ToTable("Departments");
                });

            modelBuilder.Entity("CodeacdemyCompany.DAL.Model.Employee", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("City")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("DepartmentIdDepartment")
                        .HasColumnType("int");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("IdDepartment")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<decimal>("Salary")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("age")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("DepartmentIdDepartment");

                    b.ToTable("Employees");
                });

            modelBuilder.Entity("CodeacdemyCompany.DAL.Model.Employee", b =>
                {
                    b.HasOne("CodeacdemyCompany.DAL.Model.Department", "Department")
                        .WithMany()
                        .HasForeignKey("DepartmentIdDepartment")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Department");
                });
#pragma warning restore 612, 618
        }
    }
}
