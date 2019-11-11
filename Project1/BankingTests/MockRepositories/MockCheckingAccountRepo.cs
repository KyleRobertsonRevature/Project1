using System;
using Project1.Models;
using Project1.Models.Repositories;

namespace Project1.Tests.MockRepositories
{
    public class MockCheckingAccountRepo : ICheckingAccountRepo
    {
        public CheckingAccount GetChecking(int id)
        {
            // TODO implement logic
            throw new NotImplementedException();
        }

        public void Save(CheckingAccount acc)
        {
            // TODO implement logic
            throw new NotImplementedException();
        }
    }
}
