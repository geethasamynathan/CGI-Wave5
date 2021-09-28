using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
namespace JWTTokenDemo.Models
{
    public class UserDbContext:DbContext
    {
        public UserDbContext(DbContextOptions options):base(options)
        {

        }
        public DbSet<User> Users { get; set; }
    }
}
