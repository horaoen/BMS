using BMS.Models.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace BMS.Database
{
    public class AppDbContext : IdentityDbContext<User>
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
            
        }
        public DbSet<BookTitle> BookTitles { get; set; }
        public DbSet<Loan> Loans { get; set; }
        public DbSet<Reservation> Reservations { get; set; }
        public DbSet<BookTitleItem> BookTitleItems { get; set; }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.SetInitialData();
        }
    }
}