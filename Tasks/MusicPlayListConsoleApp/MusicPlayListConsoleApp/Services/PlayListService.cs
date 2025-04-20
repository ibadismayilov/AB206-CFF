using MusicPlayListConsoleApp.Core.Enum;
using MusicPlayListConsoleApp.Core.Models;
using MusicPlayListConsoleApp.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static MusicPlayListConsoleApp.Core.Enum.Genres;

namespace MusicPlayListConsoleApp.Services;

public class PlayListService
{
    private static List<Playlist> playlists;
    public PlayListService()
    {
        playlists = new List<Playlist>();
    }

    #region Music add PlayList
    public void CreatePlayList(Playlist playlist)
    {
        if (playlist is null)
        {
            Console.WriteLine("Something went wrong");
        }
        else
        {
            var existingPlaylist = playlists.Find(item => item.PlayList == playlist.PlayList);

            if (existingPlaylist is not null)
            {
                Console.WriteLine("Play music already exists");
            }
            else
            {
                playlists.Add(playlist);
                Console.WriteLine("Playlist created");
            }
        }
    }
    #endregion

    #region Get All PlayList
    public List<Playlist> GetAllMusic()
    {
        return playlists;
    }
    #endregion

    #region
    public List<Playlist> AddMusicToPlayList(string songName, List<string> artistName, GenreEnum genre, int duration)
    {
        List<Playlist> newPlayList = new List<Playlist>();

        try
        {
            foreach (Playlist item in playlists)
            {
                Music newMusic = new Music(songName, artistName, genre, duration);

                item.Musics.Add(newMusic);
                newPlayList.Add(item);

                Console.WriteLine($"{songName} | {artistName} | {duration} | {genre}");
            }
        }
        catch
        {
            throw new PlayListException("Something went wrong");
        }

        return newPlayList;
    }
    #endregion

    #region Delete Music from Playlist
    public void DeleteMusicfromPlaylist(string songName)
    {
        try
        {
            foreach (Playlist item in playlists)
            {
                var existingMusicToPlaylist = item.Musics.Find(item => item.SongName == songName);

                if (existingMusicToPlaylist != null)
                {
                    item.Musics.Remove(existingMusicToPlaylist);
                    Console.WriteLine($"{songName} - was removed from the playlist.");
                }
                else
                {
                    Console.WriteLine($"{songName} - was not found in this playlist.");
                }
            }
        }
        catch
        {
            throw new PlayListException($"An error occurred: The song {songName} could not be deleted.");
        }
    }
    #endregion

    #region Filter Playlist with Song
    public List<Playlist> FilterPlaylistWidthSong(List<string> artistName)
    {
        List<Playlist> newPlayList = new List<Playlist>();

        try
        {
            foreach (Playlist item in playlists)
            {
                var existingMusicToPlaylist = item.Musics.Find(item => item.ArtistName == artistName);

                if (existingMusicToPlaylist != null)
                {
                    newPlayList.Add(item);

                    Console.WriteLine($"Playlist: {existingMusicToPlaylist.SongName} | Musiqi: {existingMusicToPlaylist.Genre} - {existingMusicToPlaylist.Duration}");
                }
                else
                {
                    Console.WriteLine($"{artistName} - no artist found");
                }
            }

        }
        catch
        {
            throw new PlayListException($"Something went wrong");
        }

        return newPlayList;
    }
    #endregion

    #region Delete PlayList
    public void DeletePlayList(int id)
    {
        try
        {
            foreach (Playlist item in playlists)
            {
                if (item.Id == id)
                {
                    playlists.Remove(item);
                }
            }
        }
        catch
        {
            throw new PlayListException($"{id} - PlayList with this id was not deleted");
        }
    }
    #endregion
}
