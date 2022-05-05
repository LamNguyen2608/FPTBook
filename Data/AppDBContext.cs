using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using FPTBook.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace FPTBook.Data
{
    public class AppDBContext : IdentityDbContext<ApplicationUser>
    {
        public AppDBContext(DbContextOptions<AppDBContext> options) : base(options)
        {

        }

        public DbSet<Author> Authors { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Book> Books { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Book>().HasKey(am => new
            {
                am.Id
            });

            modelBuilder.Entity<Book>().HasOne(m => m.author).WithMany(am => am.Books).HasForeignKey(m => m.authorId);
            modelBuilder.Entity<Book>().HasOne(m => m.category).WithMany(am => am.Books).HasForeignKey(m => m.catId);

            base.OnModelCreating(modelBuilder);
        }


    }
}