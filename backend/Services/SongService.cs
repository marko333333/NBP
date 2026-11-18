public class SongService
{
    private readonly IDatabase _db;
     public SongService(IDatabase db)
    {
        _db = db;
    }
}