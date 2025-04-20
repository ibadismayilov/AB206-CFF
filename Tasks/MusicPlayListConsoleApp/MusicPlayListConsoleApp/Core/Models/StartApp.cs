using MusicPlayListConsoleApp.Core.Enums;
using MusicPlayListConsoleApp.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicPlayListConsoleApp.Core.Models;

public class StartApp
{
    public void Start()
    {
        int result;

        do
        {
            Console.WriteLine("Hi, this is padarginal Spotify. This paltform name is Ipotify");
            Console.WriteLine("DEFINITELY NOT FAKE");
            Console.WriteLine("==============================================================");
            Console.WriteLine("1.Create Music");
            Console.WriteLine("2.See all music");
            Console.WriteLine("3.Update Music");

            bool isCheck = int.TryParse(Console.ReadLine(), out result);
            //SongName = songName;
            //ArtistName = artistName;
            //Genre = genre;
            //Duration = duration;
            if (isCheck)
            {
                switch (result) {
                    case 1:
                        Console.Write("Please enter Song name: ");
                        string songName = Console.ReadLine();

                        Console.Write("Please enter Artist Name: ");
                        List<string> artistName = new List<string>();

                        Console.Write("Please enter Genre: ");
                        string genre = Console.ReadLine();
                        Enum.TryParse(genre, out Genres type);

                        Console.Write("Please enter Duration ");
                        int duration = Convert.ToInt32(Console.ReadLine());

                        Music music = new Music(songName, artistName, genre, duration);

                        MusicService musicService = new MusicService();
                        musicService.CreateMusic(music);

                        break;
                }
            }

        }
        while (result != 0);
    }
}
