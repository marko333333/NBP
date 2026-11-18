public class ArtistService
{
    private readonly IDatabase _db;
     public ArtistService(IDatabase db)
    {
        _db = db;
    }
}