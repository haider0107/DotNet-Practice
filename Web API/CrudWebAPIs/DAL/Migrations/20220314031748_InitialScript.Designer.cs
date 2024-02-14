﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SelectInDepth.DAL;

#nullable disable

namespace DAL.Migrations
{
    [DbContext(typeof(OrganizationDbContext))]
    [Migration("20220314031748_InitialScript")]
    partial class InitialScript
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("SelectInDepth.BOL.DataModel.Department", b =>
                {
                    b.Property<int>("Did")
                        .HasColumnType("int");

                    b.Property<string>("DName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Did");

                    b.ToTable("Department");
                });

            modelBuilder.Entity("SelectInDepth.BOL.DataModel.Employee", b =>
                {
                    b.Property<int>("Eid")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Eid"), 1L, 1);

                    b.Property<int?>("Did")
                        .HasColumnType("int");

                    b.Property<string>("EName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Gender")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Eid");

                    b.HasIndex("Did");

                    b.ToTable("Employee");
                });

            modelBuilder.Entity("SelectInDepth.BOL.DataModel.Module", b =>
                {
                    b.Property<int>("Mid")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Mid"), 1L, 1);

                    b.Property<string>("ModuleName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Pid")
                        .HasColumnType("int");

                    b.HasKey("Mid");

                    b.HasIndex("Pid");

                    b.ToTable("Module");
                });

            modelBuilder.Entity("SelectInDepth.BOL.DataModel.Project", b =>
                {
                    b.Property<int>("Pid")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Pid"), 1L, 1);

                    b.Property<string>("ProjectName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Pid");

                    b.ToTable("Project");
                });

            modelBuilder.Entity("SelectInDepth.BOL.DataModel.Task", b =>
                {
                    b.Property<int>("Tid")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Tid"), 1L, 1);

                    b.Property<int>("Eid")
                        .HasColumnType("int");

                    b.Property<int>("Mid")
                        .HasColumnType("int");

                    b.Property<string>("TaskName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Tid");

                    b.HasIndex("Eid");

                    b.HasIndex("Mid");

                    b.ToTable("Task");
                });

            modelBuilder.Entity("SelectInDepth.BOL.DataModel.Employee", b =>
                {
                    b.HasOne("SelectInDepth.BOL.DataModel.Department", "DepartmentNvg")
                        .WithMany("Employees")
                        .HasForeignKey("Did");

                    b.Navigation("DepartmentNvg");
                });

            modelBuilder.Entity("SelectInDepth.BOL.DataModel.Module", b =>
                {
                    b.HasOne("SelectInDepth.BOL.DataModel.Project", "ProjectNvg")
                        .WithMany("Modules")
                        .HasForeignKey("Pid")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("ProjectNvg");
                });

            modelBuilder.Entity("SelectInDepth.BOL.DataModel.Task", b =>
                {
                    b.HasOne("SelectInDepth.BOL.DataModel.Employee", "EmployeeNvg")
                        .WithMany("Tasks")
                        .HasForeignKey("Eid")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SelectInDepth.BOL.DataModel.Module", "ModuleNvg")
                        .WithMany("Tasks")
                        .HasForeignKey("Mid")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("EmployeeNvg");

                    b.Navigation("ModuleNvg");
                });

            modelBuilder.Entity("SelectInDepth.BOL.DataModel.Department", b =>
                {
                    b.Navigation("Employees");
                });

            modelBuilder.Entity("SelectInDepth.BOL.DataModel.Employee", b =>
                {
                    b.Navigation("Tasks");
                });

            modelBuilder.Entity("SelectInDepth.BOL.DataModel.Module", b =>
                {
                    b.Navigation("Tasks");
                });

            modelBuilder.Entity("SelectInDepth.BOL.DataModel.Project", b =>
                {
                    b.Navigation("Modules");
                });
#pragma warning restore 612, 618
        }
    }
}
