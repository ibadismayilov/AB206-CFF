using GameStore.DAL.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static GameStore.DAL.Enums.GameGenres;

namespace GameStore.DAL.Models;

public class TrendingGames
{
    public int Id { get; set; }
    public string ImgUrl { get; set; }
    public double Price { get; set; }
    public Genres Genre { get; set; }
    public string Title { get; set; }
}
