using Chatio.Core.Models;
using Chatio.Core.Repositories;

namespace Chatio.Infrastructure.Repositories;

public class UserRepository : IUserRepository
{
    private List<User> users = new();
    public void Add(User user)
    {
        users.Add(user);
    }

    public User? Get(string ID)
    {
        return users.Find(u=>u.Id == ID);
    }

}
