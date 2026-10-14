using Microsoft.EntityFrameworkCore;
using WebApplication2.Models;

namespace WebApplication2.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Friend> Friends { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // اضافه کردن داده‌های اولیه به دیتابیس
            modelBuilder.Entity<Friend>().HasData(
                new Friend { Number = 1, Name = "Jack", ImageUrl = "/images/Jack.png" },
                new Friend { Number = 2, Name = "John", ImageUrl = "/images/John.png" },
                new Friend { Number = 3, Name = "Jimmy", ImageUrl = "/images/Jimmy.png" },
                new Friend { Number = 4, Name = "James", ImageUrl = "/images/James.png" },
                new Friend { Number = 5, Name = "Jones", ImageUrl = "/images/Jones.png" },
                new Friend { Number = 6, Name = "Jonathan", ImageUrl = "/images/Jonathan.png" },
                new Friend { Number = 7, Name = "Jakob", ImageUrl = "/images/Jakob.png" },
                new Friend { Number = 8, Name = "Jakline", ImageUrl = "/images/Jakline.png" },
                new Friend { Number = 9, Name = "Jashoa", ImageUrl = "/images/Jashoa.png" },
                new Friend { Number = 10, Name = "Jenifer", ImageUrl = "/images/Jenifer.png" }
            );
        }
    }
}