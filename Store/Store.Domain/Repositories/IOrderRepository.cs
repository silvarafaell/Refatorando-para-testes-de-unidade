using Store.Domain.Entities;

namespace Store.Domain.Repositories.Interfaces
{
    public interface IOrderRepository
    {
        //para salvar o pedido
        void Save(Order order);
    }
}