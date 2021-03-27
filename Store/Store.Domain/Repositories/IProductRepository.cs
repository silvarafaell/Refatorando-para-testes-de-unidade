using System;
using System.Collections.Generic;
using Store.Domain.Entities;

namespace Store.Domain.Repositories.Interfaces
{
    public interface IProductRepository
    {
        //retorna uma lista de produtos
        IEnumerable<Product> Get(IEnumerable<Guid> ids);
    }
}