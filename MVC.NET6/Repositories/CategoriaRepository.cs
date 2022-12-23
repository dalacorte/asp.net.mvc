using MVC.NET6.Context;
using MVC.NET6.Models;
using MVC.NET6.Repositories.Interfaces;

namespace MVC.NET6.Repositories
{
    public class CategoriaRepository : ICategoriaRepository
    {
        private readonly AppDbContext _context;

        public CategoriaRepository(AppDbContext context)
        {
            _context = context;
        }

        public IEnumerable<Categoria> Categorias => _context.Categorias;
    }
}
