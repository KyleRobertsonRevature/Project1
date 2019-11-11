using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace Project1.Models.Repositories
{
    public class UserRepo
    {
        private readonly BankingContext _context;

        public UserRepo(BankingContext c)
        {
            _context = c;
        }

        public IEnumerable<User> GetAllUsers()
        {
            return _context.Users;
        }

        // searches for a user by username. usernames should be unique. returns null if not found
        public User GetUser(string username)
        {
            return _context.Users.Include(u => u.Accounts).Where(u => u.Username == username).FirstOrDefault<User>();
        }

        public void Add(User user)
        {
            _context.Users.Add(user);
            _context.SaveChanges();
        }
    }
}
