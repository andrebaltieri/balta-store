using System.Data.SqlClient;
using Balta.Store.Data.Contracts;
using Balta.Store.Models;
using Balta.Store.Queries;
using Balta.Store.Repositories.Contracts;
using Dapper;

namespace Balta.Store.Repositories
{
    public class CustomerRepository : ICustomerRepository
    {
        private readonly IDataContext _context;

        public CustomerRepository(IDataContext context)
        {
            _context = context;
        }

        public void Save(Customer customer)
        {
            _context.Connection.Execute(CustomerQueries.Insert, new
            {
                firstName = customer.FirstName,
                lastName = customer.LastName,
                email = customer.Email,
                password = customer.Password,
            });
        }
    }
}