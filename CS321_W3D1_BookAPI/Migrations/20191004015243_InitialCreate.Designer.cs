﻿// <auto-generated />
using CS321_W3D1_BookAPI.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace CS321_W3D1_BookAPI.Migrations
{
    [DbContext(typeof(BookContext))]
    [Migration("20191004015243_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.4-servicing-10062");

            modelBuilder.Entity("CS321_W3D1_BookAPI.Models.Book", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Author")
                        .IsRequired();

                    b.Property<string>("Category")
                        .IsRequired();

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(75);

                    b.HasKey("Id");

                    b.ToTable("Books");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Author = "John Doe",
                            Category = "Fantasy",
                            Title = "Book one of Trilogy"
                        },
                        new
                        {
                            Id = 2,
                            Author = "John Doe",
                            Category = "Fantasy",
                            Title = "Book two of Trilogy"
                        },
                        new
                        {
                            Id = 3,
                            Author = "John Doe",
                            Category = "Fantasy",
                            Title = "Book three of Trilogy"
                        },
                        new
                        {
                            Id = 4,
                            Author = "John Doe",
                            Category = "Fantasy",
                            Title = "Book four of Trilogy"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
