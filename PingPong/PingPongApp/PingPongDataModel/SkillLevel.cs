using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PingPongDataModel
{
    public class SkillLevel
    {
        public int SkillLevelID { get; set; }
        public string SkillLevelName { get; set; }

        public ICollection<Player> Players { get; set; }
    }
}
