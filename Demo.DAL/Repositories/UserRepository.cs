using Demo.DAL.Entities;
using Microsoft.EntityFrameworkCore;

namespace Demo.DAL.Repositories
{
    public class UserRepository(DemoContext context)
    {
        public User? GetByUsername(string username)
        {
            return context.Users.FirstOrDefault(x => x.Username == username);
        }
    }
}
