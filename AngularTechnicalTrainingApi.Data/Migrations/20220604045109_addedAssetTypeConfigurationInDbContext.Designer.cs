﻿// <auto-generated />
using System;
using AngularTechnicalTrainingApi.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace AngularTechnicalTrainingApi.Data.Migrations
{
    [DbContext(typeof(DatabaseContext))]
    [Migration("20220604045109_addedAssetTypeConfigurationInDbContext")]
    partial class addedAssetTypeConfigurationInDbContext
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("AngularTechnicalTrainingApi.Domain.Models.Asset", b =>
                {
                    b.Property<int>("TagID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("TagID"), 1L, 1);

                    b.Property<int>("AssetTypeID")
                        .HasColumnType("int");

                    b.Property<DateTime>("DateAdded")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DateRetired")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("EmployeeID")
                        .HasColumnType("int");

                    b.Property<bool>("Retired")
                        .HasColumnType("bit");

                    b.HasKey("TagID");

                    b.HasIndex("AssetTypeID");

                    b.HasIndex("EmployeeID");

                    b.ToTable("Assets");
                });

            modelBuilder.Entity("AngularTechnicalTrainingApi.Domain.Models.AssetType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("AssetTypes");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Desktop"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Laptop"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Display"
                        },
                        new
                        {
                            Id = 4,
                            Name = "Phone"
                        },
                        new
                        {
                            Id = 5,
                            Name = "External Hard Drive"
                        },
                        new
                        {
                            Id = 6,
                            Name = "Other"
                        });
                });

            modelBuilder.Entity("AngularTechnicalTrainingApi.Domain.Models.Employee", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Employees");
                });

            modelBuilder.Entity("AngularTechnicalTrainingApi.Domain.Models.Asset", b =>
                {
                    b.HasOne("AngularTechnicalTrainingApi.Domain.Models.AssetType", "AssetType")
                        .WithMany()
                        .HasForeignKey("AssetTypeID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("AngularTechnicalTrainingApi.Domain.Models.Employee", "Employee")
                        .WithMany()
                        .HasForeignKey("EmployeeID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("AssetType");

                    b.Navigation("Employee");
                });
#pragma warning restore 612, 618
        }
    }
}
