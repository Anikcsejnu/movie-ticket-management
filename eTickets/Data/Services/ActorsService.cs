using eTickets.Models;
using Microsoft.EntityFrameworkCore;

namespace eTickets.Data.Services
{
	public class ActorsService : IActorsService
	{
		private readonly AppDbContext _context;
		public ActorsService(AppDbContext context)
        {
            this._context = context;
        }
        public void Add(Actor actor)
		{
			_context.Add(actor);
			_context.SaveChanges();
		}

		public void Delete(int id)
		{
			throw new NotImplementedException();
		}

		public Actor GetActorById(int id)
		{
			throw new NotImplementedException();
		}

		public async Task<IEnumerable<Actor>> GetAllActors()
		{
			var result = await _context.Actors.ToListAsync();
			return result;
		}

		public Actor Update(int id, Actor newActor)
		{
			throw new NotImplementedException();
		}
	}
}
