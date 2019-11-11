using System;
using Project1.Models;
using Project1.Models.Repositories;

namespace Project1.Tests.MockRepositories
{
    public class MockLoanRepo : ILoanRepo
    {
        public Loan GetLoan(int id)
        {
            // TODO implement logic
            throw new NotImplementedException();
        }

        public void Save(Loan acc)
        {
            // TODO implement logic
            throw new NotImplementedException();
        }
    }
}
