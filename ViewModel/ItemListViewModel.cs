using Aztromick2.Models;

namespace Aztromick2.ViewModel
{
    public class ItemListViewModel
    {
        public IEnumerable<Item> Itens { get; set; }
        public string CategoriaAtual { get; set; }
    }
}