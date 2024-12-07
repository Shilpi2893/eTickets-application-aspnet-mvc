using eTickets.Models;

namespace eTickets.Data.Services
{
    public interface IActorsService
    {
        // first method will get all the Actors form the database and return type is IEnumberable of Actors
        Task<IEnumerable<Actor>> GetAllActors();

        // Second method will return a Single Actor
        Actor GetById(int id);

        //Third method will add data (Actor) to the database the return type is void as we are not getting anything in return
        void Add(Actor actor);

        //Fourth method will update the Actor into databse
        Actor Update(int id, Actor newActor);

        //Fifth method will delete the Actor from the database
        void Delete(int id);
    }
}
