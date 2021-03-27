using Store.Domain.Entities;
using Store.Domain.Repositories.Interfaces;

namespace Store.Tests.Repositories
{
    public class FakeCustomerRepository : ICustomerRepository
    {
        public Customer Get(string document)
        {
            if (document == "06077829332")
                return new Customer("Francisco Rafael", "francisco_rafael@hotmail.com.br");

            return null;
        }
    }
}