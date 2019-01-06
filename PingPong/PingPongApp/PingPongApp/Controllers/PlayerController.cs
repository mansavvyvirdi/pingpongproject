using PingPongDataEntities;
using PingPongDataEntities.ViewModels;
using PingPongServiceLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace PingPongApp.Controllers
{
    public class PlayerController : ApiController
    {
        public PlayerService playerService = new PlayerService();

        [HttpGet]
        public RawResultList<PlayerViewModel> GetPlayers()
        {
            return playerService.GetPlayerList();
        }

        [HttpGet]
        public RawResultList<SkillLevel> GetSkillLevelList()
        {
            return playerService.GetSkillLevelList();
        }
        [HttpGet]
        public RawResult<Player> GetPlayerById(Int64 Id)
        {
            return playerService.GetPlayerById(Id);
        }

        [HttpPost]
        public RawResult<Int32> AddOrUpdatePlayer(PlayerViewModel player)
        {
            return playerService.AddOrUpdatePlayer(player);
        }

        [HttpDelete]
        public RawResult<Int32> DeletePlayer(Int64 Id)
        {
            return playerService.DeletePlayer(Id);
        }
    }
}