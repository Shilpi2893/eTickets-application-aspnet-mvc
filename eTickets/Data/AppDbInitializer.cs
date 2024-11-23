using eTickets.Models;

namespace eTickets.Data
{
    public class AppDbInitializer
    {
        public static void seed(IApplicationBuilder applicationBuilder)
        {
            using(IServiceScope serviceScope = applicationBuilder.ApplicationServices.CreateScope())
            {
                AppDbContext? context = serviceScope.ServiceProvider.GetService<AppDbContext>();
                if(context == null) 
                {
                    return;
                }
                context.Database.EnsureCreated();

                //Cinema
                if(!context.Cinemas.Any())
                {
                    context.Cinemas.AddRange(new List<Cinema>());
                    context.SaveChanges();
                }

                //Actors
                if(!context.Actors.Any())
                {
                    context.Actors.AddRange(new List<Actor>());
                    context.SaveChanges();
                }

                //Producers
                if(!context.Producers.Any())
                {
                    context.Producers.AddRange(new List<Producer>());
                    context.SaveChanges();
                }

                //Movies
                if(!context.Movies.Any())
                {
                    context.Movies.AddRange(new List<Movie>());
                    context.SaveChanges();
                }

                //Actor_Movies
                if (!context.Actor_Movies.Any())
                {
                    context.Actor_Movies.AddRange(new List<Actor_Movie>());
                    context.SaveChanges();
                }
            }
        }
    }
}