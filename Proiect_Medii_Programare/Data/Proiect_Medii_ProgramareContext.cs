using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Proiect_Medii_Programare.Models;

namespace Proiect_Medii_Programare.Data
{
    public class Proiect_Medii_ProgramareContext : DbContext
    {
        public Proiect_Medii_ProgramareContext(DbContextOptions<Proiect_Medii_ProgramareContext> options)
            : base(options)
        {
        }

        public DbSet<Proiect_Medii_Programare.Models.Restaurant> Restaurant { get; set; } = default!;

        public DbSet<Proiect_Medii_Programare.Models.Rezervare>? Rezervare { get; set; }

        public DbSet<Proiect_Medii_Programare.Models.Recenzie>? Recenzie { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Rezervare>()
        .HasOne(r => r.Restaurant)
        .WithMany(r => r.Rezervari)
        .HasForeignKey(r => r.RestaurantID);
        }
        public DbSet<Proiect_Medii_Programare.Models.Client>? Client { get; set; }
    }
}