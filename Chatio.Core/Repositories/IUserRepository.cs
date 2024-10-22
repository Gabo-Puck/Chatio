using Chatio.Core.Models;

namespace Chatio.Core.Repositories;

public interface IUserRepository
{
    void Add(User user);
    User? Get(string ID);
}
