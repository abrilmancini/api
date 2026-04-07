using System.Security.Cryptography.X509Certificates;
using Domain.Entities;
using Domain.Interfaces;
using Infrastructure;
using Infrastructure.Repositories;

namespace Infrastructure.Repositories;
public class UserRepository: BaseRepository<User> , IUserRepository
{
    public UserRepository(BookChampionContext context) : base(context)
    {
    }

    public void Remove(string email)
    {
        User? userToRemove = DummyUserList.Users.FirstOrDefault(u => u.Email == email);
        if (userToRemove != null)
        {
            _context.Users.Remove(userToRemove);
        }
    }
}
