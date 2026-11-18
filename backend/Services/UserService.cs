public class UserService
{
    private readonly IDatabase _db;
     public UserService(IDatabase db)
    {
        _db = db;
    }
}