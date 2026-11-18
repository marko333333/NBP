[ApiController]
[Route("api/playlists")]
public class PlaylistController : ControllerBase
{
    private readonly PlaylistService _playlists;
    public PlaylistController(PlaylistService playlists) => _playlists = playlists;
}