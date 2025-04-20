using MusicPlayListConsoleApp.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static MusicPlayListConsoleApp.Core.Enum.Genres;

namespace MusicPlayListConsoleApp.Core.Models;

public class Music : BaseClass
{
    public string SongName { get; set; }
    public List<string> ArtistName { get; set; }
    public GenreEnum Genre { get; set; }
    public int Duration { get; set; }

    public Music(string songName, List<string> artistName, GenreEnum genre, int duration)
    {
        SongName = songName;
        ArtistName = artistName;
        Genre = genre;
        Duration = duration;
    }
}
