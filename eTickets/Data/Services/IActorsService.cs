using eTickets.Models;

namespace eTickets.Data.Services
{
	public interface IActorsService
	{
		Task<IEnumerable<Actor>> GetAllAsync();
		Task<Actor> GetActorByIdAsync(int id);
		Task AddAsync(Actor actor);
		Actor Update(int id, Actor newActor);
		void Delete(int id);
	}
}
