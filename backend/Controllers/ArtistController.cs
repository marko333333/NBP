[ApiController]
[Route("api/artists")]
public class ArtistController : ControllerBase
{
    private readonly ArtistService _artists;
    public ArtistController(ArtistService artists) => _artists = artists;
}