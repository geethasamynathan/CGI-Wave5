using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JWTTokenDemo.Models
{
    public class UserRepository : IUserRepository
    {
        private readonly UserDbContext dbContext;
        public UserRepository(UserDbContext context)
        {
            dbContext = context;
        }
        public User FindByUserId(string userid)
        {
            var _user = dbContext.Users.FirstOrDefault(u => u.UserId == userid);
            return _user;
        }

        public User Login(string userid, string password)
        {
            var _user = dbContext.Users.FirstOrDefault(u => u.UserId == userid && u.Password == password);
            return _user;

        }

        public User Register(User user)
        {
            dbContext.Users.Add(user);
            dbContext.SaveChanges();
            return user;
        }
    }
}
