using System;
using System.Data.SqlClient;

namespace Balta.Store.Data.Contracts
{
    public interface IDataContext : IDisposable
    {
        SqlConnection Connection { get; }
    }
}