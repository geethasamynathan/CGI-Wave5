using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JWTTokenDemo.Exceptions
{
    public class UserNotFoundException:ApplicationException
    {
        public UserNotFoundException()
        {

        }
        public UserNotFoundException(string message):base(message)
        {

        }
    }
}
