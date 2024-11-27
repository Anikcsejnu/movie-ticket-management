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

        public async Task AddAsync(Actor actor)
		{
			await _context.AddAsync(actor);
			await _context.SaveChangesAsync();
		}

		public void Delete(int id)
		{
			throw new NotImplementedException();
		}

		public async Task<Actor> GetActorByIdAsync(int id)
		{
			var result = await _context.Actors.FirstOrDefaultAsync(x => x.Id == id);
			return result;
		}

		public async Task<IEnumerable<Actor>> GetAllAsync()
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
