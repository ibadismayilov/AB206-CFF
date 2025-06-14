using GameStore.DAL.Contexts;
using GameStore.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameStore.BL.Services;

public class TrendingGamesService
{
    private readonly AppDbContext _appDbContext;

    public TrendingGamesService()
    {
        _appDbContext = new AppDbContext();
    }

    public List<TrendingGames> GetAllGames()
    {
        var all = _appDbContext.TrendingGames.ToList();
        return all;
    }

    public TrendingGames GetGameById(int id)
    {

        var findGame = _appDbContext.TrendingGames.Find(id);

        if (findGame is null)
        {
            throw new Exception($"{id} - aid game tapılmadı");
        }

        return findGame;
    }

    public void CreateGames(TrendingGames trendingGames)
    {
         _appDbContext.TrendingGames.Add(trendingGames);
        _appDbContext.SaveChanges();
    }
}
