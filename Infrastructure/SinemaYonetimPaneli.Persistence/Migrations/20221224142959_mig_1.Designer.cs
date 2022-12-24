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
    [Migration("20221224142959_mig_1")]
    partial class mig1
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("FilmGosterim", b =>
                {
                    b.Property<int>("filmsfilmID")
                        .HasColumnType("int");

                    b.Property<int>("gosterimsgosterimID")
                        .HasColumnType("int");

                    b.HasKey("filmsfilmID", "gosterimsgosterimID");

                    b.HasIndex("gosterimsgosterimID");

                    b.ToTable("FilmGosterim");
                });

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

                    b.Property<int>("gosterimYil")
                        .HasColumnType("int");

                    b.Property<int>("salonID")
                        .HasColumnType("int");

                    b.HasKey("gosterimID");

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

            modelBuilder.Entity("FilmGosterim", b =>
                {
                    b.HasOne("SinemaYonetimPaneli.Domain.Entities.Film", null)
                        .WithMany()
                        .HasForeignKey("filmsfilmID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SinemaYonetimPaneli.Domain.Entities.Gosterim", null)
                        .WithMany()
                        .HasForeignKey("gosterimsgosterimID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("SinemaYonetimPaneli.Domain.Entities.Gosterim", b =>
                {
                    b.HasOne("SinemaYonetimPaneli.Domain.Entities.Salon", "salon")
                        .WithMany("gosterims")
                        .HasForeignKey("salonID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("salon");
                });

            modelBuilder.Entity("SinemaYonetimPaneli.Domain.Entities.Salon", b =>
                {
                    b.Navigation("gosterims");
                });
#pragma warning restore 612, 618
        }
    }
}