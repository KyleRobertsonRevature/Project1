using System;
using System.Collections.Generic;
using Project1.Models;
using Project1.Models.Repositories;

namespace Project1.Tests.MockRepositories
{
    public class MockUserRepo : IUserRepo
    {
        public User GetUser(string username)
        {
            // TODO implement logic
            throw new NotImplementedException();
        }

        public void Add(User user)
        {
            // TODO implement logic
            throw new NotImplementedException();
        }

        public IEnumerable<User> GetAllUsers()
        {
            throw new NotImplementedException();
        }
    }
}
