using Chatio.Application.UserCases;
using Chatio.Application.UserCases.Queries;
using Chatio.Core.Models;
using Microsoft.AspNetCore.Mvc;

namespace Chatio.Api.Controllers;

[ApiController]
[Route("[controller]")]
public class UserController : ControllerBase
{
    private readonly ILogger<UserController> _logger;
    private readonly CreateUserUseCase _createUserUseCase;
    private readonly GetUserQuery _getUserQuery;

    public UserController(ILogger<UserController> logger, CreateUserUseCase createUserUseCase, GetUserQuery getUserQuery)
    {
        _logger = logger;
        _createUserUseCase = createUserUseCase;
        _getUserQuery = getUserQuery;
    }

    [HttpPost]
    public IResult Post(CreateUserCommand createUserCommand)
    {
        var user = _createUserUseCase.Execute(createUserCommand);
        return TypedResults.CreatedAtRoute<User>(user);
    }

    [HttpGet]
    public IResult Get([FromQuery] GetUserQueryParam query){
        return TypedResults.Ok(_getUserQuery.Query(query));
    }
}
