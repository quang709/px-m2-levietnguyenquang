using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace baitap1311QuanLySach.Models
{
    public class AppDbContext : DbContext
    {


        public AppDbContext(DbContextOptions<AppDbContext> dbContextOptions) : base(dbContextOptions)
        {

        }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Book> Books { get; set; }

       

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Category>().HasData(new Category { Id = 1, CategoryName = "Đạo Lý" });
            modelBuilder.Entity<Category>().HasData(new Category { Id = 2, CategoryName = "Giáo Dục" });
            modelBuilder.Entity<Category>().HasData(new Category { Id = 3, CategoryName = "Làm Giàu" });

            modelBuilder.Entity<Book>().HasData(new Book
            {
                Id = 1,
                NameBook = "Đạo lý Làm Người",
                Author="Huấn Rose",
                Description = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s",
                 Year=2000,
                Stock = 500,
             
                CategoryId = 1
            });
            modelBuilder.Entity<Book>().HasData(new Book
            {
                Id = 2,
                NameBook = "Toán 12",
                Author = "Bộ Giáo Dục",
                Description = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s",
                Year = 2000,
                Stock = 500,

                CategoryId = 2
            });
            modelBuilder.Entity<Book>().HasData(new Book
            {
                Id = 3,
                NameBook = "Khởi Nghiệp tuổi 20 ",
                Author = "quang",
                Description = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s",
                Year = 2000,
                Stock = 500,

                CategoryId = 1
            }); 


        }
    }
}
