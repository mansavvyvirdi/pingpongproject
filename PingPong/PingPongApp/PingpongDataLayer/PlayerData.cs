using PingPongDataEntities;
using PingPongDataEntities.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;

namespace PingPongDataLayer
{
    public class PlayerData
    {

        public List<SkillLevel> GetSkillLevelList()
        {
            using (var ctx = new PingpongContext())
            {
                return ctx.SkillLevels.ToList();
            }
        }

        public List<PlayerViewModel> GetPlayerList()
        {
            using (var ctx = new PingpongContext())
            {
                return ctx.Players.Select(x => new PlayerViewModel
                {
                    Age = x.Age,
                    EmailAddress = x.EmailAddress,
                    FirstName = x.FirstName,
                    LastName = x.LastName,
                    PlayerId = x.PlayerId,
                    SkillLevelId = x.SkillLevel.SkillLevelID,
                    SkillLevelName = x.SkillLevel.SkillLevelName
                }).ToList();
            }
        }

        public Player GetPlayerById(Int64 Id)
        {
            using (var ctx = new PingpongContext())
            {
                return ctx.Players.FirstOrDefault(x => x.PlayerId == Id);
            }
        }

        public Int32 AddOrUpdatePlayer(Player player)
        {
            using (var ctx = new PingpongContext())
            {
                if (player.PlayerId > 0)
                {
                    ctx.Entry(player).State = System.Data.Entity.EntityState.Modified;
                }
                else
                {
                    ctx.Players.Add(player);
                }
                return ctx.SaveChanges();
            }
        }

        public Int32 DeletePlayer(Int64 Id)
        {
            using (var ctx = new PingpongContext())
            {
                Player player = ctx.Players.FirstOrDefault(x => x.PlayerId == Id);
                if (player != null)
                {
                    ctx.Players.Remove(player);
                    return ctx.SaveChanges();
                }
                return 0;
            }
        }
    }
}
