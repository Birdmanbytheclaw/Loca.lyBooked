using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Loca_ly.Models;

namespace Loca_ly.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.Entity<IdentityRole>()
            .HasData(
            new IdentityRole
            {
                Name = "Venue",
                NormalizedName = "VENUE"
            },
            new IdentityRole
            {
                Name = "Artist",
                NormalizedName = "ARTIST"
            });
     
        }
        public DbSet<Loca_ly.Models.Artist> Artist { get; set; }
        public DbSet<Loca_ly.Models.Venue> Venue { get; set; }
    }
}