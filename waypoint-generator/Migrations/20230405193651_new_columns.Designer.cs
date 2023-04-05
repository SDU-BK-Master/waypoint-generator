﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace waypoint_generator.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20230405193651_new_columns")]
    partial class new_columns
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "7.0.4");

            modelBuilder.Entity("BaseCalibrationPlan", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("CalibrationPlanType")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Comment")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("Type")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.ToTable("CalibrationPlans", (string)null);

                    b.HasDiscriminator<string>("CalibrationPlanType").HasValue("BaseCalibrationPlan");

                    b.UseTphMappingStrategy();
                });

            modelBuilder.Entity("BaseScanPlan", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Comment")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("ScanPlanType")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("Type")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.ToTable("ScanPlans", (string)null);

                    b.HasDiscriminator<string>("ScanPlanType").HasValue("BaseScanPlan");

                    b.UseTphMappingStrategy();
                });

            modelBuilder.Entity("BeamFindingPlan", b =>
                {
                    b.HasBaseType("BaseCalibrationPlan");

                    b.Property<double>("Buffer")
                        .HasColumnType("REAL");

                    b.Property<double>("Radius")
                        .HasColumnType("REAL");

                    b.Property<double>("Speed")
                        .HasColumnType("REAL");

                    b.Property<double>("StartAzimuth")
                        .HasColumnType("REAL");

                    b.Property<double>("StartElevation")
                        .HasColumnType("REAL");

                    b.Property<double>("StepAzimuth")
                        .HasColumnType("REAL");

                    b.Property<double>("StepElevation")
                        .HasColumnType("REAL");

                    b.Property<double>("StopAzimuth")
                        .HasColumnType("REAL");

                    b.Property<double>("StopElevation")
                        .HasColumnType("REAL");

                    b.HasDiscriminator().HasValue("BeamFinding");
                });

            modelBuilder.Entity("RollAlignmentPlan", b =>
                {
                    b.HasBaseType("BaseCalibrationPlan");

                    b.Property<int>("Duration")
                        .HasColumnType("INTEGER");

                    b.Property<float>("OffsetAzimuth")
                        .HasColumnType("REAL");

                    b.Property<float>("OffsetElevation")
                        .HasColumnType("REAL");

                    b.Property<float>("Radius")
                        .HasColumnType("REAL");

                    b.Property<bool>("Zenith")
                        .HasColumnType("INTEGER");

                    b.ToTable("CalibrationPlans", t =>
                        {
                            t.Property("Radius")
                                .HasColumnName("RollAlignmentPlan_Radius");
                        });

                    b.HasDiscriminator().HasValue("RollAlignment");
                });

            modelBuilder.Entity("PrincipalPlan", b =>
                {
                    b.HasBaseType("BaseScanPlan");

                    b.Property<int?>("Direction")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("Plane")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("Polarization")
                        .HasColumnType("INTEGER");

                    b.Property<double>("Radius")
                        .HasColumnType("REAL");

                    b.Property<double>("Roll")
                        .HasColumnType("REAL");

                    b.Property<double>("Speed")
                        .HasColumnType("REAL");

                    b.Property<double>("Start")
                        .HasColumnType("REAL");

                    b.Property<double>("Step")
                        .HasColumnType("REAL");

                    b.Property<double>("Stop")
                        .HasColumnType("REAL");

                    b.HasDiscriminator().HasValue("Principal");
                });

            modelBuilder.Entity("RasterPlan", b =>
                {
                    b.HasBaseType("BaseScanPlan");

                    b.Property<double>("AzimuthStart")
                        .HasColumnType("REAL");

                    b.Property<double>("AzimuthStep")
                        .HasColumnType("REAL");

                    b.Property<double>("AzimuthStop")
                        .HasColumnType("REAL");

                    b.Property<int?>("Direction")
                        .HasColumnType("INTEGER");

                    b.Property<double>("ElevationStart")
                        .HasColumnType("REAL");

                    b.Property<double>("ElevationStep")
                        .HasColumnType("REAL");

                    b.Property<double>("ElevationStop")
                        .HasColumnType("REAL");

                    b.Property<int?>("Plane")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("Polarization")
                        .HasColumnType("INTEGER");

                    b.Property<double>("Radius")
                        .HasColumnType("REAL");

                    b.Property<double>("Speed")
                        .HasColumnType("REAL");

                    b.ToTable("ScanPlans", t =>
                        {
                            t.Property("Direction")
                                .HasColumnName("RasterPlan_Direction");

                            t.Property("Plane")
                                .HasColumnName("RasterPlan_Plane");

                            t.Property("Polarization")
                                .HasColumnName("RasterPlan_Polarization");

                            t.Property("Radius")
                                .HasColumnName("RasterPlan_Radius");

                            t.Property("Speed")
                                .HasColumnName("RasterPlan_Speed");
                        });

                    b.HasDiscriminator().HasValue("Raster");
                });

            modelBuilder.Entity("SinglePointPlan", b =>
                {
                    b.HasBaseType("BaseScanPlan");

                    b.Property<double>("Duration")
                        .HasColumnType("REAL");

                    b.Property<double>("OffsetAzimuth")
                        .HasColumnType("REAL");

                    b.Property<double>("OffsetElevation")
                        .HasColumnType("REAL");

                    b.Property<int>("Polarization")
                        .HasColumnType("INTEGER");

                    b.Property<double>("Radius")
                        .HasColumnType("REAL");

                    b.ToTable("ScanPlans", t =>
                        {
                            t.Property("Polarization")
                                .HasColumnName("SinglePointPlan_Polarization");

                            t.Property("Radius")
                                .HasColumnName("SinglePointPlan_Radius");
                        });

                    b.HasDiscriminator().HasValue("SinglePoint");
                });
#pragma warning restore 612, 618
        }
    }
}
