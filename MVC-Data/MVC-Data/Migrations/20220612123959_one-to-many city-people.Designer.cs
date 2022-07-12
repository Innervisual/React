﻿// <auto-generated />
using MVC_Data.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace MVC_Data.Migrations
{
    [DbContext(typeof(ApplicationDbContent))]
    [Migration("20220612123959_one-to-many city-people")]
    partial class onetomanycitypeople
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.25")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("MVC_Data.Models.City", b =>
                {
                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("CountryName")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Name");

                    b.HasIndex("CountryName");

                    b.ToTable("Cities");

                    b.HasData(
                        new
                        {
                            Name = "London"
                        },
                        new
                        {
                            Name = "Stockholm"
                        });
                });

            modelBuilder.Entity("MVC_Data.Models.Country", b =>
                {
                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Name");

                    b.ToTable("Countries");

                    b.HasData(
                        new
                        {
                            Name = "England"
                        },
                        new
                        {
                            Name = "Sweden"
                        });
                });

            modelBuilder.Entity("MVC_Data.Models.Language", b =>
                {
                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Name");

                    b.ToTable("Langs");

                    b.HasData(
                        new
                        {
                            Name = "English"
                        },
                        new
                        {
                            Name = "Swedish"
                        });
                });

            modelBuilder.Entity("MVC_Data.Models.Person", b =>
                {
                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("CityName")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("Id")
                        .HasColumnType("int");

                    b.Property<int>("PhoneNumber")
                        .HasColumnType("int");

                    b.HasKey("Name");

                    b.HasIndex("CityName");

                    b.ToTable("People");

                    b.HasData(
                        new
                        {
                            Name = "JP",
                            Id = 1,
                            PhoneNumber = 111
                        },
                        new
                        {
                            Name = "Anders",
                            Id = 2,
                            PhoneNumber = 222
                        });
                });

            modelBuilder.Entity("MVC_Data.Models.PersonLanguage", b =>
                {
                    b.Property<string>("PersonName")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LanguageName")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("PersonName");

                    b.HasIndex("LanguageName");

                    b.ToTable("PersonLanguages");
                });

            modelBuilder.Entity("MVC_Data.Models.City", b =>
                {
                    b.HasOne("MVC_Data.Models.Country", null)
                        .WithMany("Cities")
                        .HasForeignKey("CountryName");
                });

            modelBuilder.Entity("MVC_Data.Models.Person", b =>
                {
                    b.HasOne("MVC_Data.Models.City", "City")
                        .WithMany("People")
                        .HasForeignKey("CityName");
                });

            modelBuilder.Entity("MVC_Data.Models.PersonLanguage", b =>
                {
                    b.HasOne("MVC_Data.Models.Language", "Language")
                        .WithMany("PersonLanguages")
                        .HasForeignKey("LanguageName");

                    b.HasOne("MVC_Data.Models.Person", "Person")
                        .WithMany("PersonLanguages")
                        .HasForeignKey("PersonName")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
