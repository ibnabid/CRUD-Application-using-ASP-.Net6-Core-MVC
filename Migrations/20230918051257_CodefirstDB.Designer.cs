﻿// <auto-generated />
using System;
using CODEfirstApproachCRUD.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace CODEfirstApproachCRUD.Migrations
{
    [DbContext(typeof(StudentDBContext))]
    [Migration("20230918051257_CodefirstDB")]
    partial class CodefirstDB
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.22")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("CODEfirstApproachCRUD.Models.Student", b =>
                {
                    b.Property<int?>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int?>("Id"), 1L, 1);

                    b.Property<int?>("Age")
                        .HasColumnType("int");

                    b.Property<string>("Gender")
                        .HasColumnType("varchar(20)")
                        .HasColumnName("StudentGender");

                    b.Property<string>("Name")
                        .HasColumnType("varchar(100)")
                        .HasColumnName("StudentName");

                    b.HasKey("Id");

                    b.ToTable("Students");
                });
#pragma warning restore 612, 618
        }
    }
}
