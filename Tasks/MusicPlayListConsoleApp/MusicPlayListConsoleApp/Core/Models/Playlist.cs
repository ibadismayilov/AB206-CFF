using MusicPlayListConsoleApp.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static MusicPlayListConsoleApp.Core.Enum.Genres;

namespace MusicPlayListConsoleApp.Core.Models;

public class Playlist : BaseClass
{
    public string PlayList { get; set; }
    public List<Music> Musics { get; set; }

    public Playlist(string playList, List<Music> musics)
    {
        PlayList = playList;
        Musics = musics;
    }
}
