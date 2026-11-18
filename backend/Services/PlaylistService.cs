public class PlaylistService
{
    private readonly IDatabase _db;

    public PlaylistService(IDatabase db)
    {
        _db = db;
    }
}