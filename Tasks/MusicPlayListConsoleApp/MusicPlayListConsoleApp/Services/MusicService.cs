using MusicPlayListConsoleApp.Core.Models;
using MusicPlayListConsoleApp.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicPlayListConsoleApp.Services;

public class MusicService
{
    private static List<Music> musics;
    public MusicService()
    {
        musics = new List<Music>();
    }

    #region Create Car
    public void CreateMusic(Music music)
    {
        if (music is null)
        {
            Console.WriteLine("Something went wrong");
        }
        else
        {
            var existingMusic = musics.Find(item => item.Id == music.Id);

            if (existingMusic != null)
            {
                Console.WriteLine("This music already exists");
            }
            else
            {
                musics.Add(music);
                Console.WriteLine("Music added to the list");
            }
        }
    }
    #endregion

    #region Get All Car
    public List<Music> GetAllMusic()
    {
        return musics;
    }
    #endregion

    #region Update Car
    public void UpdateMusic(int id, Music newMusic)
    {
        try
        {
            foreach (Music item in musics)
            {
                if (item.Id == id)
                {
                    item.SongName = newMusic.SongName;
                    item.ArtistName = newMusic.ArtistName;
                    item.SongName = newMusic.SongName;
                    item.Genre = newMusic.Genre;
                    item.Duration = newMusic.Duration;
                }
            }
        }
        catch
        {
            throw new MusicException($"{id} - No music found with this id");
        }
    }
    #endregion

    #region Delete Music
    public void DeleteMusic(int id)
    {
        try
        {
            foreach (Music item in musics)
            {
                if (item.Id == id)
                {
                    musics.Remove(item);
                }
            }
        }
        catch
        {
            throw new MusicException($"{id} -  Music with this id was not deleted");
        }
    }
    #endregion

}
