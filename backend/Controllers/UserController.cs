[ApiController]
[Route("api/users")]
public class UserController : ControllerBase
{
    private readonly UserService _users;
    public UserController(UserService users) => _users = users;
}