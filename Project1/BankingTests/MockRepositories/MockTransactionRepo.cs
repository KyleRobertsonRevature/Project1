using System;
using Project1.Models;
using Project1.Models.Repositories;

namespace Project1.Tests.MockRepositories
{
    public class MockTransactionRepo : ITransactionRepo
    {
        public Transaction GetTransaction(int id)
        {
            // TODO implement logic
            throw new NotImplementedException();
        }

        public void Save(Transaction transaction)
        {
            // TODO implement logic
            throw new NotImplementedException();
        }
    }
}
