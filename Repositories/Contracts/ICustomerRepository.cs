using Balta.Store.Models;

namespace Balta.Store.Repositories.Contracts
{
    public interface ICustomerRepository
    {
        void Save(Customer customer);
    }
}