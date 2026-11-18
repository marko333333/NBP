[ApiController]
[Route("api/songs")]
public class SongController : ControllerBase
{
    private readonly SongService _songs;
    public SongController(SongService songs) => _songs = songs;
}