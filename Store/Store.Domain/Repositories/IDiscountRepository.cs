using Store.Domain.Entities;

namespace Store.Domain.Repositories.Interfaces
{
    public interface IDiscountRepository
    {
        //responsavel por retornar desconto
        Discount Get(string code);
    }
}