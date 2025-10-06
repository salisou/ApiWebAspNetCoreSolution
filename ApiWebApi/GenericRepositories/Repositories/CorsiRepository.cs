using ApiWebApi.Data;
using ApiWebApi.GenericRepositoris.Repositories;
using ApiWebApi.Models;
using Microsoft.EntityFrameworkCore;

namespace ApiWebApi.GenericRepositories.Repositories
{
    public class CorsiRepository : GenericRepository<Corsi>
    {
        private readonly ApiWebContext _context;
        public CorsiRepository(ApiWebContext context) : base(context)
        {
            _context = context;
        }

        public async Task<Corsi?> GetByIdWithStudentiAsync(int id)
        {
            return await _context.Corsi
                .Include(c => c.Studenti)
                .FirstOrDefaultAsync(c => c.IdCorso == id);
        }
    }
}
