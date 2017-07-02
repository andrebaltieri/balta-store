namespace Balta.Store.Queries
{
    public static class CustomerQueries
    {
        public const string Insert = "INSERT INTO [Customer] ([FirstName],[LastName],[Email],[Password]) VALUES(@firstName, @lastName, @email, @password)";
    }
}