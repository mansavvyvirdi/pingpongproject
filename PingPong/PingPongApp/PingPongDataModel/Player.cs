using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PingPongDataModel
{
   public class Player
    {
        [Key]
        public long PlayerId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int? Age { get; set; }
        public string EmailAddress { get; set; }
       
        public SkillLevel SkillLevel { get; set; }
    }
}
