﻿// <auto-generated />
using Final.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Final.Migrations
{
    [DbContext(typeof(BasicDataContext))]
    [Migration("20231211054717_ChangedModels1")]
    partial class ChangedModels1
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.25")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Final.Models.Company", b =>
                {
                    b.Property<int>("CompanyId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CompanyId"), 1L, 1);

                    b.Property<string>("CompanyName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CompanyId");

                    b.ToTable("Companies");

                    b.HasData(
                        new
                        {
                            CompanyId = 1,
                            CompanyName = "Company 1"
                        },
                        new
                        {
                            CompanyId = 2,
                            CompanyName = "Company 2"
                        },
                        new
                        {
                            CompanyId = 3,
                            CompanyName = "Company 3"
                        },
                        new
                        {
                            CompanyId = 4,
                            CompanyName = "Company 4"
                        },
                        new
                        {
                            CompanyId = 5,
                            CompanyName = "Company 5"
                        },
                        new
                        {
                            CompanyId = 6,
                            CompanyName = "Company 6"
                        },
                        new
                        {
                            CompanyId = 7,
                            CompanyName = "Company 7"
                        },
                        new
                        {
                            CompanyId = 8,
                            CompanyName = "Company 8"
                        },
                        new
                        {
                            CompanyId = 9,
                            CompanyName = "Company 9"
                        },
                        new
                        {
                            CompanyId = 10,
                            CompanyName = "Company 10"
                        });
                });

            modelBuilder.Entity("Final.Models.Contact", b =>
                {
                    b.Property<int>("ContactId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ContactId"), 1L, 1);

                    b.Property<int>("CompanyId")
                        .HasColumnType("int");

                    b.Property<string>("ContactName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("CountryId")
                        .HasColumnType("int");

                    b.HasKey("ContactId");

                    b.HasIndex("CompanyId");

                    b.HasIndex("CountryId");

                    b.ToTable("Contacts");

                    b.HasData(
                        new
                        {
                            ContactId = 1,
                            CompanyId = 1,
                            ContactName = "Contact 1",
                            CountryId = 1
                        },
                        new
                        {
                            ContactId = 2,
                            CompanyId = 2,
                            ContactName = "Contact 2",
                            CountryId = 2
                        },
                        new
                        {
                            ContactId = 3,
                            CompanyId = 3,
                            ContactName = "Contact 3",
                            CountryId = 3
                        },
                        new
                        {
                            ContactId = 4,
                            CompanyId = 4,
                            ContactName = "Contact 4",
                            CountryId = 4
                        },
                        new
                        {
                            ContactId = 5,
                            CompanyId = 5,
                            ContactName = "Contact 5",
                            CountryId = 5
                        },
                        new
                        {
                            ContactId = 6,
                            CompanyId = 6,
                            ContactName = "Contact 6",
                            CountryId = 6
                        },
                        new
                        {
                            ContactId = 7,
                            CompanyId = 7,
                            ContactName = "Contact 7",
                            CountryId = 7
                        },
                        new
                        {
                            ContactId = 8,
                            CompanyId = 8,
                            ContactName = "Contact 8",
                            CountryId = 8
                        },
                        new
                        {
                            ContactId = 9,
                            CompanyId = 9,
                            ContactName = "Contact 9",
                            CountryId = 9
                        },
                        new
                        {
                            ContactId = 10,
                            CompanyId = 10,
                            ContactName = "Contact 10",
                            CountryId = 10
                        });
                });

            modelBuilder.Entity("Final.Models.Country", b =>
                {
                    b.Property<int>("CountryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CountryId"), 1L, 1);

                    b.Property<string>("CountryName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CountryId");

                    b.ToTable("Contries");

                    b.HasData(
                        new
                        {
                            CountryId = 1,
                            CountryName = "Country 1"
                        },
                        new
                        {
                            CountryId = 2,
                            CountryName = "Country 2"
                        },
                        new
                        {
                            CountryId = 3,
                            CountryName = "Country 3"
                        },
                        new
                        {
                            CountryId = 4,
                            CountryName = "Country 4"
                        },
                        new
                        {
                            CountryId = 5,
                            CountryName = "Country 5"
                        },
                        new
                        {
                            CountryId = 6,
                            CountryName = "Country 6"
                        },
                        new
                        {
                            CountryId = 7,
                            CountryName = "Country 7"
                        },
                        new
                        {
                            CountryId = 8,
                            CountryName = "Country 8"
                        },
                        new
                        {
                            CountryId = 9,
                            CountryName = "Country 9"
                        },
                        new
                        {
                            CountryId = 10,
                            CountryName = "Country 10"
                        });
                });

            modelBuilder.Entity("Final.Models.Contact", b =>
                {
                    b.HasOne("Final.Models.Company", null)
                        .WithMany("Contacts")
                        .HasForeignKey("CompanyId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Final.Models.Country", null)
                        .WithMany("Contacts")
                        .HasForeignKey("CountryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Final.Models.Company", b =>
                {
                    b.Navigation("Contacts");
                });

            modelBuilder.Entity("Final.Models.Country", b =>
                {
                    b.Navigation("Contacts");
                });
#pragma warning restore 612, 618
        }
    }
}
