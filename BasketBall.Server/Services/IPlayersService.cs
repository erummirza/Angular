﻿
using BasketBall.Server.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Basketball.Services
{
    public interface IPlayersService
    {
        Task<IEnumerable<Player>> GetPlayersList();
        Task<Player> GetPlayerById(int id);
        Task<Player> CreatePlayer(Player player);
        Task UpdatePlayer(Player player);
        Task DeletePlayer(Player player);
    }
}