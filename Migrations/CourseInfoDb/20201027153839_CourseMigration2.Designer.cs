﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using NickCollege.InfoData;

namespace NickCollege.Migrations.CourseInfoDb
{
    [DbContext(typeof(CourseInfoDbContext))]
    [Migration("20201027153839_CourseMigration2")]
    partial class CourseMigration2
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("NickCollege.Models.CourseInfo", b =>
                {
                    b.Property<int>("CourseID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CourseDescribtion")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CourseName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Credits")
                        .HasColumnType("int");

                    b.Property<int?>("SectionID")
                        .HasColumnType("int");

                    b.Property<double>("average")
                        .HasColumnType("float");

                    b.Property<double>("grade1")
                        .HasColumnType("float");

                    b.Property<double>("grade10")
                        .HasColumnType("float");

                    b.Property<double>("grade2")
                        .HasColumnType("float");

                    b.Property<double>("grade3")
                        .HasColumnType("float");

                    b.Property<double>("grade4")
                        .HasColumnType("float");

                    b.Property<double>("grade5")
                        .HasColumnType("float");

                    b.Property<double>("grade6")
                        .HasColumnType("float");

                    b.Property<double>("grade7")
                        .HasColumnType("float");

                    b.Property<double>("grade8")
                        .HasColumnType("float");

                    b.Property<double>("grade9")
                        .HasColumnType("float");

                    b.HasKey("CourseID");

                    b.ToTable("CourseInfo");
                });
#pragma warning restore 612, 618
        }
    }
}
