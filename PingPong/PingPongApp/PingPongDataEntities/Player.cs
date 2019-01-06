using System;
using System.ComponentModel.DataAnnotations;

namespace PingPongDataEntities
{
    public class Player
    {
        [Key]
        public long PlayerId { get; set; }
        [MaxLength(50)]
        public string FirstName { get; set; }
        [MaxLength(50)]
        public string LastName { get; set; }
        public int? Age { get; set; }
        [MaxLength(250)]
        public string EmailAddress { get; set; }
        public int SkillLevelId { get; set; }


        public SkillLevel SkillLevel { get; set; }
    }
}
