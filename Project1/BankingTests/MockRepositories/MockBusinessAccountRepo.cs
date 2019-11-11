using Project1.Models;
using Project1.Models.Repositories;
using System;
using System.Collections.Generic;

namespace Project1.Tests.MockRepositories
{
    public class MockBusinessAccountRepo : IBusinessAccountRepo
    {
        public IEnumerable<BusinessAccount> GetAccounts()
        {
            throw new NotImplementedException();
        }

        public BusinessAccount GetBusiness(int id)
        {
            // TODO implement logic
            throw new NotImplementedException();
        }

        public void Save(BusinessAccount acc)
        {
            // TODO implement logic
            throw new NotImplementedException();
        }
    }
}
