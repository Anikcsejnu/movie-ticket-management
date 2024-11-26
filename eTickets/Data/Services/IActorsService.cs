using eTickets.Models;

namespace eTickets.Data.Services
{
	public interface IActorsService
	{
		Task<IEnumerable<Actor>> GetAllActors();
		Actor GetActorById(int id);
		void Add(Actor actor);
		Actor Update(int id, Actor newActor);
		void Delete(int id);
	}
}
