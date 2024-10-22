using Chatio.Core.Models;
using Chatio.Core.Repositories;

namespace Chatio.Application.UserCases.Queries;

public class GetUserQuery { 
    private IUserRepository _userRepository;
    public GetUserQuery(IUserRepository userRepository){
        _userRepository = userRepository;
    }
    public User Query(GetUserQueryParam param){
        return _userRepository.Get(param.ID);
    }
}
