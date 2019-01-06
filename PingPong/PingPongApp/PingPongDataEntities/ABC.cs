using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace PingPongDataEntities
{
    public class ABC
    {
        [Key]
        public int ID { get; set; }

        public string Name { get; set; }

    }
}
