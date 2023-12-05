using Aztromick2.Models;

namespace Aztromick2.ViewModel
{
    public class PedidoItensViewModel
    {
        public Pedido Pedidos {get;set;}
        public IEnumerable<PedidoItem> PedidoItens {get;set;}
    }
}