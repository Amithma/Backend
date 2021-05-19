﻿// <auto-generated />
using System;
using AuthDemo.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace AuthDemo.Migrations
{
    [DbContext(typeof(DBContext))]
    [Migration("20210425061443_initial1")]
    partial class initial1
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.4")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("AuthDemo.Models.AsComponent", b =>
                {
                    b.Property<int>("AsID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Ascomponent")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LD")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LOID")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Marks")
                        .HasColumnType("int");

                    b.Property<string>("ModuleId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("POID")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Type")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("AsID");

                    b.HasIndex("ModuleId");

                    b.HasIndex("POID");

                    b.ToTable("AsComponents");
                });

            modelBuilder.Entity("AuthDemo.Models.LO", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("LOID")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ModuleId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.HasIndex("ModuleId");

                    b.ToTable("LOs");
                });

            modelBuilder.Entity("AuthDemo.Models.Module", b =>
                {
                    b.Property<string>("ModuleId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Credits")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("State")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("type")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ModuleId");

                    b.ToTable("Modules");
                });

            modelBuilder.Entity("AuthDemo.Models.PO", b =>
                {
                    b.Property<string>("POID")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("ID")
                        .HasColumnType("int");

                    b.Property<string>("LOID")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("POName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("POID");

                    b.ToTable("POs");
                });

            modelBuilder.Entity("AuthDemo.Models.User", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NormalizedUserName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("Role")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("AuthDemo.Models.WeatherForecast", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<string>("Summary")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("TemperatureC")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("WeatherForecasts");
                });

            modelBuilder.Entity("LOPO", b =>
                {
                    b.Property<int>("LOsID")
                        .HasColumnType("int");

                    b.Property<string>("POsPOID")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LOsID", "POsPOID");

                    b.HasIndex("POsPOID");

                    b.ToTable("LOPO");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NormalizedName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("IdentityRole");

                    b.HasData(
                        new
                        {
                            Id = "baf9fc7d-cc71-44fb-951b-ebc66ac54d31",
                            ConcurrencyStamp = "3cc13480-c94e-4f76-9cc5-0d2dcc6bf0f7",
                            Name = "User",
                            NormalizedName = "USER"
                        },
                        new
                        {
                            Id = "968f4e5b-aedf-4fa6-becb-b0087c8f491a",
                            ConcurrencyStamp = "f27e0c85-981e-498d-a839-07fbe191d358",
                            Name = "Administrator",
                            NormalizedName = "ADMINISTRATOR"
                        },
                        new
                        {
                            Id = "6faffd1a-6335-4270-bf7e-e483c5ea77c5",
                            ConcurrencyStamp = "4255b5bc-59d9-4f87-8265-0d35a3dd7a1f",
                            Name = "Lecturer",
                            NormalizedName = "LECTURER"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.ToTable("IdentityUserRole<string>");
                });

            modelBuilder.Entity("AuthDemo.Models.AsComponent", b =>
                {
                    b.HasOne("AuthDemo.Models.Module", "Module")
                        .WithMany("AsComponents")
                        .HasForeignKey("ModuleId");

                    b.HasOne("AuthDemo.Models.PO", null)
                        .WithMany("AsComponents")
                        .HasForeignKey("POID");

                    b.Navigation("Module");
                });

            modelBuilder.Entity("AuthDemo.Models.LO", b =>
                {
                    b.HasOne("AuthDemo.Models.Module", "Module")
                        .WithMany("LOs")
                        .HasForeignKey("ModuleId");

                    b.Navigation("Module");
                });

            modelBuilder.Entity("LOPO", b =>
                {
                    b.HasOne("AuthDemo.Models.LO", null)
                        .WithMany()
                        .HasForeignKey("LOsID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("AuthDemo.Models.PO", null)
                        .WithMany()
                        .HasForeignKey("POsPOID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("AuthDemo.Models.Module", b =>
                {
                    b.Navigation("AsComponents");

                    b.Navigation("LOs");
                });

            modelBuilder.Entity("AuthDemo.Models.PO", b =>
                {
                    b.Navigation("AsComponents");
                });
#pragma warning restore 612, 618
        }
    }
}
