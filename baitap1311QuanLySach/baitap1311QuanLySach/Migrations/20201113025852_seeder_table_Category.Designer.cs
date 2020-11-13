﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using baitap1311QuanLySach.Models;

namespace baitap1311QuanLySach.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20201113025852_seeder_table_Category")]
    partial class seeder_table_Category
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.0");

            modelBuilder.Entity("baitap1311QuanLySach.Models.Book", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Author")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NameBook")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Stock")
                        .HasColumnType("int");

                    b.Property<int>("Year")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.ToTable("Books");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Author = "Huấn Rose",
                            CategoryId = 1,
                            Description = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s",
                            NameBook = "Đạo lý Làm Người",
                            Stock = 500,
                            Year = 2000
                        },
                        new
                        {
                            Id = 2,
                            Author = "Bộ Giáo Dục",
                            CategoryId = 2,
                            Description = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s",
                            NameBook = "Toán 12",
                            Stock = 500,
                            Year = 2000
                        },
                        new
                        {
                            Id = 3,
                            Author = "quang",
                            CategoryId = 1,
                            Description = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s",
                            NameBook = "Khởi Nghiệp tuổi 20 ",
                            Stock = 500,
                            Year = 2000
                        });
                });

            modelBuilder.Entity("baitap1311QuanLySach.Models.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("CategoryName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CategoryName = "Đạo Lý"
                        },
                        new
                        {
                            Id = 2,
                            CategoryName = "Giáo Dục"
                        },
                        new
                        {
                            Id = 3,
                            CategoryName = "Làm Giàu"
                        });
                });

            modelBuilder.Entity("baitap1311QuanLySach.Models.Book", b =>
                {
                    b.HasOne("baitap1311QuanLySach.Models.Category", "Category")
                        .WithMany("Books")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");
                });

            modelBuilder.Entity("baitap1311QuanLySach.Models.Category", b =>
                {
                    b.Navigation("Books");
                });
#pragma warning restore 612, 618
        }
    }
}
