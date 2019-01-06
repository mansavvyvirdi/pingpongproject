using PingPongDataEntities;
using PingPongDataEntities.ViewModels;
using PingPongDataLayer;
using System;
using System.Collections.Generic;

namespace PingPongServiceLayer
{
    public class PlayerService
    {
        public PlayerData playerData = new PlayerData();

        public RawResultList<SkillLevel> GetSkillLevelList()
        {
            RawResultList<SkillLevel> obj = new RawResultList<SkillLevel>();
            obj.Data = playerData.GetSkillLevelList();
            obj.StatusCode = (int)StatusCode.Success;
            return obj;
        }

        public RawResultList<PlayerViewModel> GetPlayerList()
        {
            RawResultList<PlayerViewModel> obj = new RawResultList<PlayerViewModel>();
            obj.Data = playerData.GetPlayerList();
            obj.StatusCode = (int)StatusCode.Success;
            return obj;
        }

        public RawResult<Player> GetPlayerById(Int64 Id)
        {
            RawResult<Player> obj = new RawResult<Player>();
            obj.Data = playerData.GetPlayerById(Id);
            obj.StatusCode = (int)(obj.Data != null ? StatusCode.Success : StatusCode.NotFound);
            return obj;
        }

        public RawResult<Int32> AddOrUpdatePlayer(PlayerViewModel playerViewModel)
        {
            RawResult<Int32> obj = new RawResult<Int32>();
            Player player = new Player();
            player.Age = playerViewModel.Age;
            player.EmailAddress = playerViewModel.EmailAddress;
            player.FirstName = playerViewModel.FirstName;
            player.LastName = playerViewModel.LastName;
            player.PlayerId = playerViewModel.PlayerId;
            player.SkillLevelId = playerViewModel.SkillLevelId;
            obj.Data = playerData.AddOrUpdatePlayer(player);
            obj.StatusCode = (int)(obj.Data > 0 ? StatusCode.Success : StatusCode.Error);
            return obj;
        }

        public RawResult<Int32> DeletePlayer(Int64 Id)
        {
            RawResult<Int32> obj = new RawResult<Int32>();
            obj.Data = playerData.DeletePlayer(Id);
            obj.StatusCode = (int)(obj.Data > 0 ? StatusCode.Success : StatusCode.Error);
            return obj;
        }
    }
}
