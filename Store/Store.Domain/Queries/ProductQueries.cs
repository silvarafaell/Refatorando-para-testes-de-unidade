using System;
using System.Linq.Expressions;
using Store.Domain.Entities;

namespace Store.Domain.Queries
{
    public static class ProductQueries
    {
        public static Expression<Func<Product, bool>> GetActiveProducts()
        {
            //retorna apenas os produtos ativos
            return x => x.Active;
        }

        public static Expression<Func<Product, bool>> GetInactiveProducts()
        {
            //retorna apenas os produtos falsos
            return x => x.Active == false;
        }
    }
}