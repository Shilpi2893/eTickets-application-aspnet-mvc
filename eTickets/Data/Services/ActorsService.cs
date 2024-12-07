using eTickets.Models;
using Microsoft.EntityFrameworkCore;

namespace eTickets.Data.Services
{
    public class ActorsService : IActorsService
    {
        private readonly AppDbContext _appDbContext;

        public ActorsService(AppDbContext appDbContext) 
        {
            _appDbContext = appDbContext;
        }

        public async Task<IEnumerable<Actor>> GetAllActors()
        {
            var actors = await _appDbContext.Actors.ToListAsync();
            return actors;
        }

        public void Add(Actor actor)
        {
            _appDbContext.Actors.Add(actor);
            _appDbContext.SaveChanges();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }     

        public Actor GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Actor Update(int id, Actor newActor)
        {
            throw new NotImplementedException();
        }
    }
}
