using Chatio.Core.Models;
using Chatio.Core.Repositories;

namespace Chatio.Application.UserCases;

public class CreateUserUseCase
{
    private readonly IUserRepository _userRepository;
    public CreateUserUseCase(IUserRepository userRepository){
        _userRepository = userRepository;
    }
    public User Execute(CreateUserCommand createUserCommand){
        var newUser = new User{
            Email = createUserCommand.Email,
            Password = createUserCommand.Password,
            Username = createUserCommand.Username,
            Id = Guid.NewGuid().ToString()
        };
        Console.WriteLine(newUser.Id);
        _userRepository.Add(newUser);
        return newUser;
    }
}
