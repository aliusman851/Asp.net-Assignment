﻿// <auto-generated />
using System;
using Asp.net_Assignment.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Asp.net_Assignment.Migrations
{
    [DbContext(typeof(EventsContext))]
    [Migration("20210322195705_initialcreate")]
    partial class initialcreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.4")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Asp.net_Assignment.Models.Attendee", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("attendees");
                });

            modelBuilder.Entity("Asp.net_Assignment.Models.Event", b =>
                {
                    b.Property<int>("EventID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Adress")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("AttendeeID")
                        .HasColumnType("int");

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("OrganizerID")
                        .HasColumnType("int");

                    b.Property<string>("Place")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SpotsAvailable")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("EventID");

                    b.HasIndex("AttendeeID");

                    b.HasIndex("OrganizerID");

                    b.ToTable("events");
                });

            modelBuilder.Entity("Asp.net_Assignment.Models.Organizer", b =>
                {
                    b.Property<int>("OrganizerID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("OrganizerID");

                    b.ToTable("organizers");
                });

            modelBuilder.Entity("Asp.net_Assignment.Models.Event", b =>
                {
                    b.HasOne("Asp.net_Assignment.Models.Attendee", "Attendee")
                        .WithMany("Event")
                        .HasForeignKey("AttendeeID");

                    b.HasOne("Asp.net_Assignment.Models.Organizer", "organizer")
                        .WithMany("Event")
                        .HasForeignKey("OrganizerID");

                    b.Navigation("Attendee");

                    b.Navigation("organizer");
                });

            modelBuilder.Entity("Asp.net_Assignment.Models.Attendee", b =>
                {
                    b.Navigation("Event");
                });

            modelBuilder.Entity("Asp.net_Assignment.Models.Organizer", b =>
                {
                    b.Navigation("Event");
                });
#pragma warning restore 612, 618
        }
    }
}
