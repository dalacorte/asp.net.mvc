using Microsoft.EntityFrameworkCore;
using MVC.NET6.Context;
using MVC.NET6.Models;
using MVC.NET6.Repositories.Interfaces;

namespace MVC.NET6.Repositories
{
    public class LancheRepository : ILancheRepository
    {
        private readonly AppDbContext _context;

        public LancheRepository(AppDbContext context)
        {
            _context = context;
        }

        public IEnumerable<Lanche> Lanches => _context.Lanches.Include(i => i.Categoria);

        public IEnumerable<Lanche> LanchesPreferidos => _context.Lanches.Include(i => i.Categoria).Where(w => w.IsLanchePreferido);

        public Lanche GetLancheById(int id) => _context.Lanches.Include(i => i.Categoria).FirstOrDefault(f => f.Equals(id));
    }
}
