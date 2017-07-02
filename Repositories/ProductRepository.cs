using System.Data.SqlClient;
using Balta.Store.Models;
using Dapper;

namespace Balta.Store.Repositories
{
    public class ProductRepository
    {
        public void Save(Product product)
        {
            using (var conn = new SqlConnection(Settings.ConnectionString))
            {
                // conn.Open();
                // conn.Execute("INSERT INTO [Customer] ([FirstName],[LastName],[Email],[Password]) VALUES(@firstName, @lastName, @email, @password)",
                // new {
                //     firstName = customer.FirstName,
                //     lastName = customer.LastName,
                //     email = customer.Email,
                //     password = customer.Password,
                //  });
            }
        }
    }
}