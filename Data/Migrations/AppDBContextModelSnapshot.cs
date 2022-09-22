﻿// <auto-generated />
using BlazorCRUD.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace BlazorCRUD.Data.Migrations
{
    [DbContext(typeof(AppDBContext))]
    partial class AppDBContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "6.0.9");

            modelBuilder.Entity("BlazorCRUD.Data.Post", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Content")
                        .IsRequired()
                        .HasMaxLength(4096)
                        .HasColumnType("TEXT");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(128)
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Posts");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Content = "This content for advertisement 1.",
                            Title = "Advertisement 1"
                        },
                        new
                        {
                            Id = 2,
                            Content = "This content for advertisement 2.",
                            Title = "Advertisement 2"
                        },
                        new
                        {
                            Id = 3,
                            Content = "This content for advertisement 3.",
                            Title = "Advertisement 3"
                        },
                        new
                        {
                            Id = 4,
                            Content = "This content for advertisement 4.",
                            Title = "Advertisement 4"
                        },
                        new
                        {
                            Id = 5,
                            Content = "This content for advertisement 5.",
                            Title = "Advertisement 5"
                        },
                        new
                        {
                            Id = 6,
                            Content = "This content for advertisement 6.",
                            Title = "Advertisement 6"
                        },
                        new
                        {
                            Id = 7,
                            Content = "This content for advertisement 7.",
                            Title = "Advertisement 7"
                        },
                        new
                        {
                            Id = 8,
                            Content = "This content for advertisement 8.",
                            Title = "Advertisement 8"
                        },
                        new
                        {
                            Id = 9,
                            Content = "This content for advertisement 9.",
                            Title = "Advertisement 9"
                        },
                        new
                        {
                            Id = 10,
                            Content = "This content for advertisement 10.",
                            Title = "Advertisement 10"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
