﻿// <auto-generated />
using System;
using CampAprilSix.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace CampAprilSix.Migrations
{
    [DbContext(typeof(CampAprilSixContext))]
    [Migration("20200408224413_mealupdate")]
    partial class mealupdate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("CampAprilSix.Models.Camper", b =>
                {
                    b.Property<Guid>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("BirthDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("EnrollmentDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("FirstMidName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("phone")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("Campers");
                });

            modelBuilder.Entity("CampAprilSix.Models.Enrollment", b =>
                {
                    b.Property<Guid>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("CamperID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("GameID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("MealID")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("ID");

                    b.HasIndex("CamperID");

                    b.HasIndex("GameID");

                    b.HasIndex("MealID");

                    b.ToTable("Enrollments");
                });

            modelBuilder.Entity("CampAprilSix.Models.Game", b =>
                {
                    b.Property<Guid>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("SportA")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("SportB")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.ToTable("Games");
                });

            modelBuilder.Entity("CampAprilSix.Models.Meal", b =>
                {
                    b.Property<Guid>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("Breakfast")
                        .HasColumnType("int");

                    b.Property<int>("Lunch")
                        .HasColumnType("int");

                    b.Property<int>("Type")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.ToTable("Meals");
                });

            modelBuilder.Entity("CampAprilSix.Models.Enrollment", b =>
                {
                    b.HasOne("CampAprilSix.Models.Camper", "Camper")
                        .WithMany("Enrollments")
                        .HasForeignKey("CamperID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CampAprilSix.Models.Game", "Game")
                        .WithMany("Enrollments")
                        .HasForeignKey("GameID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CampAprilSix.Models.Meal", "Meal")
                        .WithMany()
                        .HasForeignKey("MealID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
