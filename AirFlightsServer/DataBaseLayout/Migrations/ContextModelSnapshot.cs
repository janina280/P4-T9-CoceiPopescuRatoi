﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace DataBaseLayout.Migrations
{
    [DbContext(typeof(Context.Context))]
    partial class ContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("DataBaseLayout.Models.AirFlight", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Currency")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Price")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("AirFlights");
                });

            modelBuilder.Entity("DataBaseLayout.Models.Company", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Raiting")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Companies");
                });

            modelBuilder.Entity("DataBaseLayout.Models.Layover", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("AirFlightId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("CompanyId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("DepartureTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("DestinationAirport")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DestinationCity")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DestinationCountry")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("FlightDuration")
                        .HasColumnType("datetime2");

                    b.Property<string>("StartPointAirport")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("StartPointCity")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("StartPointCountry")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("AirFlightId");

                    b.HasIndex("CompanyId");

                    b.ToTable("Layovers");
                });

            modelBuilder.Entity("DataBaseLayout.Models.PlaneFacility", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("PlaneFacilities");
                });

            modelBuilder.Entity("DataBaseLayout.Models.PlaneSeat", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("IsOcuppied")
                        .HasColumnType("bit");

                    b.Property<Guid>("LayoverId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("LayoverId");

                    b.ToTable("PlaneSeats");
                });

            modelBuilder.Entity("DataBaseLayout.Models.Reservation", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("UserCNP")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserCNP");

                    b.ToTable("Reservations");
                });

            modelBuilder.Entity("DataBaseLayout.Models.Role", b =>
                {
                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Name");

                    b.ToTable("Roles");
                });

            modelBuilder.Entity("DataBaseLayout.Models.User", b =>
                {
                    b.Property<string>("CNP")
                        .HasColumnType("nvarchar(450)");

                    b.Property<byte[]>("Document")
                        .IsRequired()
                        .HasColumnType("varbinary(max)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<byte[]>("ProfileImage")
                        .IsRequired()
                        .HasColumnType("varbinary(max)");

                    b.Property<string>("RoleName")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("CNP");

                    b.HasIndex("RoleName");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("LayoverPlaneFacility", b =>
                {
                    b.Property<Guid>("LayoversId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("PlaneFacilityId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("LayoversId", "PlaneFacilityId");

                    b.HasIndex("PlaneFacilityId");

                    b.ToTable("LayoverPlaneFacility");
                });

            modelBuilder.Entity("PlaneSeatReservation", b =>
                {
                    b.Property<Guid>("PlaneSeatId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("ReservationId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("PlaneSeatId", "ReservationId");

                    b.HasIndex("ReservationId");

                    b.ToTable("PlaneSeatReservation");
                });

            modelBuilder.Entity("DataBaseLayout.Models.Layover", b =>
                {
                    b.HasOne("DataBaseLayout.Models.AirFlight", "AirFlight")
                        .WithMany("Layovers")
                        .HasForeignKey("AirFlightId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DataBaseLayout.Models.Company", "Company")
                        .WithMany("Layovers")
                        .HasForeignKey("CompanyId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("AirFlight");

                    b.Navigation("Company");
                });

            modelBuilder.Entity("DataBaseLayout.Models.PlaneSeat", b =>
                {
                    b.HasOne("DataBaseLayout.Models.Layover", "Layover")
                        .WithMany("PlaneSeat")
                        .HasForeignKey("LayoverId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Layover");
                });

            modelBuilder.Entity("DataBaseLayout.Models.Reservation", b =>
                {
                    b.HasOne("DataBaseLayout.Models.User", "User")
                        .WithMany("Reservations")
                        .HasForeignKey("UserCNP")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("DataBaseLayout.Models.User", b =>
                {
                    b.HasOne("DataBaseLayout.Models.Role", "Role")
                        .WithMany("Users")
                        .HasForeignKey("RoleName")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Role");
                });

            modelBuilder.Entity("LayoverPlaneFacility", b =>
                {
                    b.HasOne("DataBaseLayout.Models.Layover", null)
                        .WithMany()
                        .HasForeignKey("LayoversId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DataBaseLayout.Models.PlaneFacility", null)
                        .WithMany()
                        .HasForeignKey("PlaneFacilityId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("PlaneSeatReservation", b =>
                {
                    b.HasOne("DataBaseLayout.Models.PlaneSeat", null)
                        .WithMany()
                        .HasForeignKey("PlaneSeatId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DataBaseLayout.Models.Reservation", null)
                        .WithMany()
                        .HasForeignKey("ReservationId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("DataBaseLayout.Models.AirFlight", b =>
                {
                    b.Navigation("Layovers");
                });

            modelBuilder.Entity("DataBaseLayout.Models.Company", b =>
                {
                    b.Navigation("Layovers");
                });

            modelBuilder.Entity("DataBaseLayout.Models.Layover", b =>
                {
                    b.Navigation("PlaneSeat");
                });

            modelBuilder.Entity("DataBaseLayout.Models.Role", b =>
                {
                    b.Navigation("Users");
                });

            modelBuilder.Entity("DataBaseLayout.Models.User", b =>
                {
                    b.Navigation("Reservations");
                });
#pragma warning restore 612, 618
        }
    }
}
