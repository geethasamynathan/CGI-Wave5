using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JWTTokenDemo.Models
{
   public  interface IUserRepository
    {
        User FindByUserId(string userid);
        User Register(User user);
        User Login(string userid, string password);
    }
}
