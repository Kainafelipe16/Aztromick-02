using Aztromick2.Context;
using Aztromick2.Models;
using Aztromick2.Repositories.Interfaces;

namespace Aztromick2.Repositories
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