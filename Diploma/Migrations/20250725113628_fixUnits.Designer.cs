﻿// <auto-generated />
using System;
using Diploma.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Diploma.Migrations
{
    [DbContext(typeof(MyDbContext))]
    [Migration("20250725113628_fixUnits")]
    partial class fixUnits
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "9.0.7")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Diploma.Models.Add.AbonentAdd", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<int?>("AbonentArhiveID")
                        .HasColumnType("int");

                    b.Property<int?>("AbonentCalcID")
                        .HasColumnType("int");

                    b.Property<int>("AbonentNumber")
                        .HasColumnType("int");

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)");

                    b.Property<bool>("ChangeStatus")
                        .HasColumnType("bit");

                    b.Property<DateOnly>("ConclusionDate")
                        .HasColumnType("date");

                    b.Property<int>("ContractAddId")
                        .HasColumnType("int");

                    b.Property<int>("ControllerAddId")
                        .HasColumnType("int");

                    b.Property<int?>("ControllersAddID")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("ID");

                    b.HasIndex("AbonentArhiveID")
                        .IsUnique()
                        .HasFilter("[AbonentArhiveID] IS NOT NULL");

                    b.HasIndex("AbonentCalcID");

                    b.HasIndex("ContractAddId");

                    b.HasIndex("ControllersAddID");

                    b.ToTable("Abonents");
                });

            modelBuilder.Entity("Diploma.Models.Add.ContractAdd", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)");

                    b.Property<DateOnly>("ConclusionDate")
                        .HasColumnType("date");

                    b.Property<int?>("ContractArhiveID")
                        .HasColumnType("int");

                    b.Property<int?>("ContractCalcID")
                        .HasColumnType("int");

                    b.Property<int>("ContractNumber")
                        .HasColumnType("int");

                    b.Property<string>("FIO")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)");

                    b.HasKey("ID");

                    b.HasIndex("ContractArhiveID")
                        .IsUnique()
                        .HasFilter("[ContractArhiveID] IS NOT NULL");

                    b.HasIndex("ContractCalcID");

                    b.ToTable("Contracts");
                });

            modelBuilder.Entity("Diploma.Models.Add.ControllersAdd", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<int>("ContollerNum")
                        .HasColumnType("int");

                    b.Property<string>("FIO")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)");

                    b.HasKey("ID");

                    b.ToTable("ControllersAdds");
                });

            modelBuilder.Entity("Diploma.Models.Add.MeterAdd", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<bool>("Active")
                        .HasColumnType("bit");

                    b.Property<int?>("MeterArhiveID")
                        .HasColumnType("int");

                    b.Property<int?>("MeterCalcID")
                        .HasColumnType("int");

                    b.Property<string>("Number")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<DateOnly>("СommissioningDate")
                        .HasColumnType("date");

                    b.HasKey("ID");

                    b.HasIndex("MeterArhiveID")
                        .IsUnique()
                        .HasFilter("[MeterArhiveID] IS NOT NULL");

                    b.HasIndex("MeterCalcID");

                    b.ToTable("Meters");
                });

            modelBuilder.Entity("Diploma.Models.Add.MountMeterAdd", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<bool>("Active")
                        .HasColumnType("bit");

                    b.Property<int>("MeterID")
                        .HasColumnType("int");

                    b.Property<int?>("MountMeterArhiveID")
                        .HasColumnType("int");

                    b.Property<int?>("MountMeterCalcID")
                        .HasColumnType("int");

                    b.Property<DateOnly>("SetDate")
                        .HasColumnType("date");

                    b.HasKey("ID");

                    b.HasIndex("MeterID")
                        .IsUnique();

                    b.HasIndex("MountMeterArhiveID")
                        .IsUnique()
                        .HasFilter("[MountMeterArhiveID] IS NOT NULL");

                    b.HasIndex("MountMeterCalcID");

                    b.ToTable("MountMeters");
                });

            modelBuilder.Entity("Diploma.Models.Add.PointAdd", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<int?>("AbonentAddId")
                        .HasColumnType("int");

                    b.Property<int?>("ContractAddId")
                        .HasColumnType("int");

                    b.Property<string>("Location")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<int>("Number")
                        .HasColumnType("int");

                    b.Property<int?>("PointArhiveID")
                        .HasColumnType("int");

                    b.Property<int?>("PointCalcID")
                        .HasColumnType("int");

                    b.Property<int>("Type")
                        .HasColumnType("int");

                    b.Property<int>("Version")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("AbonentAddId");

                    b.HasIndex("ContractAddId");

                    b.HasIndex("PointArhiveID")
                        .IsUnique()
                        .HasFilter("[PointArhiveID] IS NOT NULL");

                    b.HasIndex("PointCalcID");

                    b.ToTable("Points");
                });

            modelBuilder.Entity("Diploma.Models.Add.PointsBoundAdd", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<int>("PointIDBase")
                        .HasColumnType("int");

                    b.Property<int>("PointIDMinus")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("PointIDBase");

                    b.HasIndex("PointIDMinus");

                    b.ToTable("PointsBounds");
                });

            modelBuilder.Entity("Diploma.Models.Add.TransformerAdd", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int?>("PointAddID")
                        .HasColumnType("int");

                    b.Property<int?>("TransformerAddID")
                        .HasColumnType("int");

                    b.Property<int?>("TransformerArhiveID")
                        .HasColumnType("int");

                    b.Property<int?>("TransformerCalcID")
                        .HasColumnType("int");

                    b.Property<DateOnly>("СommissioningDate")
                        .HasColumnType("date");

                    b.HasKey("ID");

                    b.HasIndex("PointAddID");

                    b.HasIndex("TransformerAddID");

                    b.HasIndex("TransformerArhiveID")
                        .IsUnique()
                        .HasFilter("[TransformerArhiveID] IS NOT NULL");

                    b.HasIndex("TransformerCalcID");

                    b.ToTable("Transformers");
                });

            modelBuilder.Entity("Diploma.Models.Add.UnitAdd", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<int>("MountMeterID")
                        .HasColumnType("int");

                    b.Property<string>("Number")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("PointAddId")
                        .HasColumnType("int");

                    b.Property<bool>("Type")
                        .HasColumnType("bit");

                    b.Property<int?>("UnitArhiveID")
                        .HasColumnType("int");

                    b.Property<int?>("UnitCalcID")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("MountMeterID")
                        .IsUnique();

                    b.HasIndex("PointAddId");

                    b.HasIndex("UnitArhiveID")
                        .IsUnique()
                        .HasFilter("[UnitArhiveID] IS NOT NULL");

                    b.HasIndex("UnitCalcID");

                    b.ToTable("Units");
                });

            modelBuilder.Entity("Diploma.Models.Arhive.AbonentArhive", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<int>("AbonentNumber")
                        .HasColumnType("int");

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)");

                    b.Property<DateOnly>("BreakDate")
                        .HasColumnType("date");

                    b.Property<DateOnly>("ConclusionDate")
                        .HasColumnType("date");

                    b.Property<int?>("ContractArhiveID")
                        .HasColumnType("int");

                    b.Property<int>("ContractNumber")
                        .HasColumnType("int");

                    b.Property<int>("ControllerNumber")
                        .HasColumnType("int");

                    b.Property<int?>("ControllersAddID")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("ID");

                    b.HasIndex("ContractArhiveID");

                    b.HasIndex("ControllersAddID");

                    b.ToTable("AbonentsArhive");
                });

            modelBuilder.Entity("Diploma.Models.Arhive.ContractArhive", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateOnly>("BreakDate")
                        .HasColumnType("date");

                    b.Property<int>("ContractNumber")
                        .HasColumnType("int");

                    b.Property<string>("FIO")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)");

                    b.HasKey("ID");

                    b.ToTable("ContractsArhive");
                });

            modelBuilder.Entity("Diploma.Models.Arhive.MeterArhive", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<bool>("Active")
                        .HasColumnType("bit");

                    b.Property<int>("Number")
                        .HasColumnType("int");

                    b.Property<DateOnly>("СommissioningDate")
                        .HasColumnType("date");

                    b.HasKey("ID");

                    b.ToTable("MetersArhive");
                });

            modelBuilder.Entity("Diploma.Models.Arhive.MountMeterArhive", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<bool>("Active")
                        .HasColumnType("bit");

                    b.Property<DateOnly>("SetDate")
                        .HasColumnType("date");

                    b.HasKey("ID");

                    b.ToTable("MountMetersArhive");
                });

            modelBuilder.Entity("Diploma.Models.Arhive.PointArhive", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<int?>("AbonentArhiveID")
                        .HasColumnType("int");

                    b.Property<DateOnly>("CreateDate")
                        .HasColumnType("date");

                    b.Property<string>("Location")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)");

                    b.Property<int>("Number")
                        .HasColumnType("int");

                    b.Property<string>("Version")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("ID");

                    b.HasIndex("AbonentArhiveID");

                    b.ToTable("PointsArhive");
                });

            modelBuilder.Entity("Diploma.Models.Arhive.TransformerArhive", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateOnly>("BreakDate")
                        .HasColumnType("date");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int?>("TransformerArhiveID")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("TransformerArhiveID");

                    b.ToTable("TransformersArhive");
                });

            modelBuilder.Entity("Diploma.Models.Arhive.UnitArhive", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<int?>("PointArhiveID")
                        .HasColumnType("int");

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasColumnType("nvarchar(1)");

                    b.HasKey("ID");

                    b.HasIndex("PointArhiveID");

                    b.ToTable("UnitsArhive");
                });

            modelBuilder.Entity("Diploma.Models.ShortCalc.AbonentSC", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<int>("AbonentNumber")
                        .HasColumnType("int");

                    b.Property<int>("ContractNumber")
                        .HasColumnType("int");

                    b.Property<int?>("ContractSCID")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("ContractSCID");

                    b.ToTable("AbonentsShortCalc");
                });

            modelBuilder.Entity("Diploma.Models.ShortCalc.ContractSC", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<int>("ContractNumber")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.ToTable("ContractsShortCalc");
                });

            modelBuilder.Entity("Diploma.Models.ShortCalc.MeterSC", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<bool>("Active")
                        .HasColumnType("bit");

                    b.Property<int>("Number")
                        .HasColumnType("int");

                    b.Property<DateOnly>("СommissioningDate")
                        .HasColumnType("date");

                    b.HasKey("ID");

                    b.ToTable("MetersShortCalc");
                });

            modelBuilder.Entity("Diploma.Models.ShortCalc.MountMeterSC", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<bool>("Active")
                        .HasColumnType("bit");

                    b.Property<DateOnly>("SetDate")
                        .HasColumnType("date");

                    b.HasKey("ID");

                    b.ToTable("MountMetersShortCalc");
                });

            modelBuilder.Entity("Diploma.Models.ShortCalc.PointSC", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<int?>("AbonentSCID")
                        .HasColumnType("int");

                    b.Property<int>("Number")
                        .HasColumnType("int");

                    b.Property<string>("Version")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("ID");

                    b.HasIndex("AbonentSCID");

                    b.ToTable("PointsShortCalc");
                });

            modelBuilder.Entity("Diploma.Models.ShortCalc.TransformerSC", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<DateOnly>("СommissioningDate")
                        .HasColumnType("date");

                    b.HasKey("ID");

                    b.ToTable("TransformersShortCalc");
                });

            modelBuilder.Entity("Diploma.Models.ShortCalc.UnitSC", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<int?>("PointSCID")
                        .HasColumnType("int");

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasColumnType("nvarchar(1)");

                    b.HasKey("ID");

                    b.HasIndex("PointSCID");

                    b.ToTable("UnitsShortCalc");
                });

            modelBuilder.Entity("Diploma.Models.Add.AbonentAdd", b =>
                {
                    b.HasOne("Diploma.Models.Arhive.AbonentArhive", "AbonentArhive")
                        .WithOne("AbonentInfo")
                        .HasForeignKey("Diploma.Models.Add.AbonentAdd", "AbonentArhiveID");

                    b.HasOne("Diploma.Models.ShortCalc.AbonentSC", "AbonentCalc")
                        .WithMany()
                        .HasForeignKey("AbonentCalcID");

                    b.HasOne("Diploma.Models.Add.ContractAdd", "ContractAdd")
                        .WithMany("Abonents")
                        .HasForeignKey("ContractAddId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Diploma.Models.Add.ControllersAdd", "ControllersAdd")
                        .WithMany("AbonentAdds")
                        .HasForeignKey("ControllersAddID");

                    b.Navigation("AbonentArhive");

                    b.Navigation("AbonentCalc");

                    b.Navigation("ContractAdd");

                    b.Navigation("ControllersAdd");
                });

            modelBuilder.Entity("Diploma.Models.Add.ContractAdd", b =>
                {
                    b.HasOne("Diploma.Models.Arhive.ContractArhive", "ContractArhive")
                        .WithOne("ContractInfo")
                        .HasForeignKey("Diploma.Models.Add.ContractAdd", "ContractArhiveID");

                    b.HasOne("Diploma.Models.ShortCalc.ContractSC", "ContractCalc")
                        .WithMany()
                        .HasForeignKey("ContractCalcID");

                    b.Navigation("ContractArhive");

                    b.Navigation("ContractCalc");
                });

            modelBuilder.Entity("Diploma.Models.Add.MeterAdd", b =>
                {
                    b.HasOne("Diploma.Models.Arhive.MeterArhive", "MeterArhive")
                        .WithOne("MeterInfo")
                        .HasForeignKey("Diploma.Models.Add.MeterAdd", "MeterArhiveID");

                    b.HasOne("Diploma.Models.ShortCalc.MeterSC", "MeterCalc")
                        .WithMany()
                        .HasForeignKey("MeterCalcID");

                    b.Navigation("MeterArhive");

                    b.Navigation("MeterCalc");
                });

            modelBuilder.Entity("Diploma.Models.Add.MountMeterAdd", b =>
                {
                    b.HasOne("Diploma.Models.Add.MeterAdd", "Meter")
                        .WithOne("MountMeter")
                        .HasForeignKey("Diploma.Models.Add.MountMeterAdd", "MeterID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Diploma.Models.Arhive.MountMeterArhive", "MountMeterArhive")
                        .WithOne("MountMeterInfo")
                        .HasForeignKey("Diploma.Models.Add.MountMeterAdd", "MountMeterArhiveID");

                    b.HasOne("Diploma.Models.ShortCalc.MountMeterSC", "MountMeterCalc")
                        .WithMany()
                        .HasForeignKey("MountMeterCalcID");

                    b.Navigation("Meter");

                    b.Navigation("MountMeterArhive");

                    b.Navigation("MountMeterCalc");
                });

            modelBuilder.Entity("Diploma.Models.Add.PointAdd", b =>
                {
                    b.HasOne("Diploma.Models.Add.AbonentAdd", "AbonentAdd")
                        .WithMany("Points")
                        .HasForeignKey("AbonentAddId");

                    b.HasOne("Diploma.Models.Add.ContractAdd", "ContractAdd")
                        .WithMany()
                        .HasForeignKey("ContractAddId");

                    b.HasOne("Diploma.Models.Arhive.PointArhive", "PointArhive")
                        .WithOne("PointInfo")
                        .HasForeignKey("Diploma.Models.Add.PointAdd", "PointArhiveID");

                    b.HasOne("Diploma.Models.ShortCalc.PointSC", "PointCalc")
                        .WithMany()
                        .HasForeignKey("PointCalcID");

                    b.Navigation("AbonentAdd");

                    b.Navigation("ContractAdd");

                    b.Navigation("PointArhive");

                    b.Navigation("PointCalc");
                });

            modelBuilder.Entity("Diploma.Models.Add.PointsBoundAdd", b =>
                {
                    b.HasOne("Diploma.Models.Add.PointAdd", "PointBase")
                        .WithMany("PointsBoundBase")
                        .HasForeignKey("PointIDBase")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Diploma.Models.Add.PointAdd", "PointMinus")
                        .WithMany("PointsBoundMinus")
                        .HasForeignKey("PointIDMinus")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("PointBase");

                    b.Navigation("PointMinus");
                });

            modelBuilder.Entity("Diploma.Models.Add.TransformerAdd", b =>
                {
                    b.HasOne("Diploma.Models.Add.PointAdd", null)
                        .WithMany("Transformers")
                        .HasForeignKey("PointAddID");

                    b.HasOne("Diploma.Models.Add.TransformerAdd", null)
                        .WithMany("Transformers")
                        .HasForeignKey("TransformerAddID");

                    b.HasOne("Diploma.Models.Arhive.TransformerArhive", "TransformerArhive")
                        .WithOne("TransformerInfo")
                        .HasForeignKey("Diploma.Models.Add.TransformerAdd", "TransformerArhiveID");

                    b.HasOne("Diploma.Models.ShortCalc.TransformerSC", "TransformerCalc")
                        .WithMany()
                        .HasForeignKey("TransformerCalcID");

                    b.Navigation("TransformerArhive");

                    b.Navigation("TransformerCalc");
                });

            modelBuilder.Entity("Diploma.Models.Add.UnitAdd", b =>
                {
                    b.HasOne("Diploma.Models.Add.MountMeterAdd", "MountMeter")
                        .WithOne("Unit")
                        .HasForeignKey("Diploma.Models.Add.UnitAdd", "MountMeterID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Diploma.Models.Add.PointAdd", "PointAdd")
                        .WithMany("Units")
                        .HasForeignKey("PointAddId");

                    b.HasOne("Diploma.Models.Arhive.UnitArhive", "UnitArhive")
                        .WithOne("UnitInfo")
                        .HasForeignKey("Diploma.Models.Add.UnitAdd", "UnitArhiveID");

                    b.HasOne("Diploma.Models.ShortCalc.UnitSC", "UnitCalc")
                        .WithMany()
                        .HasForeignKey("UnitCalcID");

                    b.Navigation("MountMeter");

                    b.Navigation("PointAdd");

                    b.Navigation("UnitArhive");

                    b.Navigation("UnitCalc");
                });

            modelBuilder.Entity("Diploma.Models.Arhive.AbonentArhive", b =>
                {
                    b.HasOne("Diploma.Models.Arhive.ContractArhive", null)
                        .WithMany("AbonentArhives")
                        .HasForeignKey("ContractArhiveID");

                    b.HasOne("Diploma.Models.Add.ControllersAdd", null)
                        .WithMany("AbonentArhives")
                        .HasForeignKey("ControllersAddID");
                });

            modelBuilder.Entity("Diploma.Models.Arhive.PointArhive", b =>
                {
                    b.HasOne("Diploma.Models.Arhive.AbonentArhive", null)
                        .WithMany("Points")
                        .HasForeignKey("AbonentArhiveID");
                });

            modelBuilder.Entity("Diploma.Models.Arhive.TransformerArhive", b =>
                {
                    b.HasOne("Diploma.Models.Arhive.TransformerArhive", null)
                        .WithMany("Transformers")
                        .HasForeignKey("TransformerArhiveID");
                });

            modelBuilder.Entity("Diploma.Models.Arhive.UnitArhive", b =>
                {
                    b.HasOne("Diploma.Models.Arhive.PointArhive", null)
                        .WithMany("Units")
                        .HasForeignKey("PointArhiveID");
                });

            modelBuilder.Entity("Diploma.Models.ShortCalc.AbonentSC", b =>
                {
                    b.HasOne("Diploma.Models.ShortCalc.ContractSC", null)
                        .WithMany("Abonents")
                        .HasForeignKey("ContractSCID");
                });

            modelBuilder.Entity("Diploma.Models.ShortCalc.PointSC", b =>
                {
                    b.HasOne("Diploma.Models.ShortCalc.AbonentSC", null)
                        .WithMany("Points")
                        .HasForeignKey("AbonentSCID");
                });

            modelBuilder.Entity("Diploma.Models.ShortCalc.UnitSC", b =>
                {
                    b.HasOne("Diploma.Models.ShortCalc.PointSC", null)
                        .WithMany("Units")
                        .HasForeignKey("PointSCID");
                });

            modelBuilder.Entity("Diploma.Models.Add.AbonentAdd", b =>
                {
                    b.Navigation("Points");
                });

            modelBuilder.Entity("Diploma.Models.Add.ContractAdd", b =>
                {
                    b.Navigation("Abonents");
                });

            modelBuilder.Entity("Diploma.Models.Add.ControllersAdd", b =>
                {
                    b.Navigation("AbonentAdds");

                    b.Navigation("AbonentArhives");
                });

            modelBuilder.Entity("Diploma.Models.Add.MeterAdd", b =>
                {
                    b.Navigation("MountMeter");
                });

            modelBuilder.Entity("Diploma.Models.Add.MountMeterAdd", b =>
                {
                    b.Navigation("Unit")
                        .IsRequired();
                });

            modelBuilder.Entity("Diploma.Models.Add.PointAdd", b =>
                {
                    b.Navigation("PointsBoundBase");

                    b.Navigation("PointsBoundMinus");

                    b.Navigation("Transformers");

                    b.Navigation("Units");
                });

            modelBuilder.Entity("Diploma.Models.Add.TransformerAdd", b =>
                {
                    b.Navigation("Transformers");
                });

            modelBuilder.Entity("Diploma.Models.Arhive.AbonentArhive", b =>
                {
                    b.Navigation("AbonentInfo");

                    b.Navigation("Points");
                });

            modelBuilder.Entity("Diploma.Models.Arhive.ContractArhive", b =>
                {
                    b.Navigation("AbonentArhives");

                    b.Navigation("ContractInfo");
                });

            modelBuilder.Entity("Diploma.Models.Arhive.MeterArhive", b =>
                {
                    b.Navigation("MeterInfo");
                });

            modelBuilder.Entity("Diploma.Models.Arhive.MountMeterArhive", b =>
                {
                    b.Navigation("MountMeterInfo");
                });

            modelBuilder.Entity("Diploma.Models.Arhive.PointArhive", b =>
                {
                    b.Navigation("PointInfo");

                    b.Navigation("Units");
                });

            modelBuilder.Entity("Diploma.Models.Arhive.TransformerArhive", b =>
                {
                    b.Navigation("TransformerInfo");

                    b.Navigation("Transformers");
                });

            modelBuilder.Entity("Diploma.Models.Arhive.UnitArhive", b =>
                {
                    b.Navigation("UnitInfo");
                });

            modelBuilder.Entity("Diploma.Models.ShortCalc.AbonentSC", b =>
                {
                    b.Navigation("Points");
                });

            modelBuilder.Entity("Diploma.Models.ShortCalc.ContractSC", b =>
                {
                    b.Navigation("Abonents");
                });

            modelBuilder.Entity("Diploma.Models.ShortCalc.PointSC", b =>
                {
                    b.Navigation("Units");
                });
#pragma warning restore 612, 618
        }
    }
}
