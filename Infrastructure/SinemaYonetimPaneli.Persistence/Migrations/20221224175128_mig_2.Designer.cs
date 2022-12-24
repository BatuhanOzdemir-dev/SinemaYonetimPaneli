﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SinemaYonetimPaneli.Persistence.Contexts;

#nullable disable

namespace SinemaYonetimPaneli.Persistence.Migrations
{
    [DbContext(typeof(SinemaYonetimPaneliDbContext))]
    [Migration("20221224175128_mig_2")]
    partial class mig2
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("SinemaYonetimPaneli.Domain.Entities.Film", b =>
                {
                    b.Property<int>("filmID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("filmID"));

                    b.Property<string>("filmAd")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("filmYapimYil")
                        .HasColumnType("int");

                    b.HasKey("filmID");

                    b.ToTable("Films");
                });

            modelBuilder.Entity("SinemaYonetimPaneli.Domain.Entities.Gosterim", b =>
                {
                    b.Property<int>("gosterimID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("gosterimID"));

                    b.Property<int>("filmID")
                        .HasColumnType("int");

                    b.Property<int>("gosterimYil")
                        .HasColumnType("int");

                    b.Property<int>("salonID")
                        .HasColumnType("int");

                    b.HasKey("gosterimID");

                    b.HasIndex("filmID");

                    b.HasIndex("salonID");

                    b.ToTable("Gosterims");
                });

            modelBuilder.Entity("SinemaYonetimPaneli.Domain.Entities.Salon", b =>
                {
                    b.Property<int>("salonID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("salonID"));

                    b.Property<string>("salonAd")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("salonID");

                    b.ToTable("Salons");
                });

            modelBuilder.Entity("SinemaYonetimPaneli.Domain.Entities.Gosterim", b =>
                {
                    b.HasOne("SinemaYonetimPaneli.Domain.Entities.Film", "film")
                        .WithMany("gosterims")
                        .HasForeignKey("filmID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SinemaYonetimPaneli.Domain.Entities.Salon", "salon")
                        .WithMany("gosterims")
                        .HasForeignKey("salonID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("film");

                    b.Navigation("salon");
                });

            modelBuilder.Entity("SinemaYonetimPaneli.Domain.Entities.Film", b =>
                {
                    b.Navigation("gosterims");
                });

            modelBuilder.Entity("SinemaYonetimPaneli.Domain.Entities.Salon", b =>
                {
                    b.Navigation("gosterims");
                });
#pragma warning restore 612, 618
        }
    }
}
