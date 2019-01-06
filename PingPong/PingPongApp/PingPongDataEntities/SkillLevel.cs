using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace PingPongDataEntities
{
    public class SkillLevel
    {
        [Key]
        public int SkillLevelID { get; set; }
        [MaxLength(100)]
        public string SkillLevelName { get; set; }

        public ICollection<Player> Players { get; set; }
    }
}
