using E_Ticket.Models;
using System.Collections.Generic;
using System.Reflection.Emit;
using Microsoft.EntityFrameworkCore;
using E_Ticket.Data.Enums;

namespace E_Ticket.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> Options) : base(Options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Actor_Movie>().HasKey(a => new { a.ActorId, a.MovieId });
            modelBuilder.Entity<Actor_Movie>().HasOne(b => b.Movie).WithMany(a => a.Actors_Movies).HasForeignKey(b => b.MovieId);
            modelBuilder.Entity<Actor_Movie>().HasOne(b => b.Actor).WithMany(a => a.Actors_Movies).HasForeignKey(b => b.ActorId);
            base.OnModelCreating(modelBuilder);

            
        }
        public DbSet<Actor> Actors { get; set; }
        public DbSet<Movie> Movies { get; set; }
        public DbSet<Actor_Movie> Actors_Movies { get; set; }
        public DbSet<Cinema> Cinemas { get; set; }
        public DbSet<Producer> Producers { get; set; }
    }
}
