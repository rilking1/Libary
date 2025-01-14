﻿// <auto-generated />
using System;
using Libary.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Libary.Migrations
{
    [DbContext(typeof(DblibaryContext))]
    [Migration("20240624234617_alfa")]
    partial class alfa
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Libary.Data.Autor", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("AutorName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Pseudonym")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("RegionId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("RegionId");

                    b.ToTable("Autors");
                });

            modelBuilder.Entity("Libary.Data.Delivery", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("PostOfficeAdress")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("PostOfficeNumber")
                        .HasColumnType("int");

                    b.Property<int?>("ReaderId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ReaderId");

                    b.ToTable("Deliveries");
                });

            modelBuilder.Entity("Libary.Data.Epoch", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("EpochName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Epoches");
                });

            modelBuilder.Entity("Libary.Data.Genre", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("GenreName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Genres");
                });

            modelBuilder.Entity("Libary.Data.LibaryCheck", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime?>("DateTime")
                        .HasColumnType("datetime2");

                    b.Property<int>("DeliveryId")
                        .HasColumnType("int");

                    b.Property<int>("PublicationId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("DeliveryId");

                    b.HasIndex("PublicationId");

                    b.ToTable("LibaryChecks");
                });

            modelBuilder.Entity("Libary.Data.Publication", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Annotation")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("BookName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("EpochId")
                        .HasColumnType("int");

                    b.Property<int>("GenreId")
                        .HasColumnType("int");

                    b.Property<int?>("PageCout")
                        .HasColumnType("int");

                    b.Property<int?>("Price")
                        .HasColumnType("int");

                    b.Property<int?>("Year")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("EpochId");

                    b.HasIndex("GenreId");

                    b.ToTable("Publications");
                });

            modelBuilder.Entity("Libary.Data.PublicationAutor", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("AutorId")
                        .HasColumnType("int");

                    b.Property<int>("PublicationId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("AutorId");

                    b.HasIndex("PublicationId");

                    b.ToTable("PublicationAutors");
                });

            modelBuilder.Entity("Libary.Data.Reader", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NickName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Readers");
                });

            modelBuilder.Entity("Libary.Data.Region", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("RegionName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Regions");
                });

            modelBuilder.Entity("Libary.Data.Autor", b =>
                {
                    b.HasOne("Libary.Data.Region", "Region")
                        .WithMany("Autors")
                        .HasForeignKey("RegionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Region");
                });

            modelBuilder.Entity("Libary.Data.Delivery", b =>
                {
                    b.HasOne("Libary.Data.Reader", "Reader")
                        .WithMany("Deliveries")
                        .HasForeignKey("ReaderId");

                    b.Navigation("Reader");
                });

            modelBuilder.Entity("Libary.Data.LibaryCheck", b =>
                {
                    b.HasOne("Libary.Data.Delivery", "Delivery")
                        .WithMany("LibaryChecks")
                        .HasForeignKey("DeliveryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Libary.Data.Publication", "Publication")
                        .WithMany("LibaryChecks")
                        .HasForeignKey("PublicationId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Delivery");

                    b.Navigation("Publication");
                });

            modelBuilder.Entity("Libary.Data.Publication", b =>
                {
                    b.HasOne("Libary.Data.Epoch", "Epoch")
                        .WithMany("Publications")
                        .HasForeignKey("EpochId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Libary.Data.Genre", "Genre")
                        .WithMany("Publications")
                        .HasForeignKey("GenreId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Epoch");

                    b.Navigation("Genre");
                });

            modelBuilder.Entity("Libary.Data.PublicationAutor", b =>
                {
                    b.HasOne("Libary.Data.Autor", "Autor")
                        .WithMany("PublicationAutors")
                        .HasForeignKey("AutorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Libary.Data.Publication", "Publication")
                        .WithMany("PublicationAutors")
                        .HasForeignKey("PublicationId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Autor");

                    b.Navigation("Publication");
                });

            modelBuilder.Entity("Libary.Data.Autor", b =>
                {
                    b.Navigation("PublicationAutors");
                });

            modelBuilder.Entity("Libary.Data.Delivery", b =>
                {
                    b.Navigation("LibaryChecks");
                });

            modelBuilder.Entity("Libary.Data.Epoch", b =>
                {
                    b.Navigation("Publications");
                });

            modelBuilder.Entity("Libary.Data.Genre", b =>
                {
                    b.Navigation("Publications");
                });

            modelBuilder.Entity("Libary.Data.Publication", b =>
                {
                    b.Navigation("LibaryChecks");

                    b.Navigation("PublicationAutors");
                });

            modelBuilder.Entity("Libary.Data.Reader", b =>
                {
                    b.Navigation("Deliveries");
                });

            modelBuilder.Entity("Libary.Data.Region", b =>
                {
                    b.Navigation("Autors");
                });
#pragma warning restore 612, 618
        }
    }
}
