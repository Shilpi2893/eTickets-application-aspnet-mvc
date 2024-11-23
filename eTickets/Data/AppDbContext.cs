using eTickets.Models;
using Microsoft.EntityFrameworkCore;

namespace eTickets.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) 
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Actor_Movie>().HasKey(actorMovies => new
            {
                actorMovies.ActorId,
                actorMovies.MovieId
            });

            modelBuilder.Entity<Actor_Movie>().HasOne(movie => movie.Movie)
                .WithMany(actorMovies => actorMovies.Actor_Movies)
                .HasForeignKey(movie => movie.MovieId);

            modelBuilder.Entity<Actor_Movie>().HasOne(movie => movie.Actor)
                .WithMany(actorMovies => actorMovies.Actor_Movies)
                .HasForeignKey(movie => movie.ActorId);

            modelBuilder.Entity<Actor>();

            base.OnModelCreating(modelBuilder);
        }

        public DbSet<Actor> Actors { get; set; }
        public DbSet<Movie> Movies { get; set; }
        public DbSet<Actor_Movie> Actor_Movies { get; set; }
        public DbSet<Cinema> Cinemas { get; set; }
        public DbSet<Producer> Producers { get; set; }
    }
}