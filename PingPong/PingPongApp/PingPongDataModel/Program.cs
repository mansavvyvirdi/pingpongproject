using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PingPongDataModel
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var ctx = new PingpongContext())
            {
                var pl = new Player() { FirstName = "Bill" };

                ctx.Players.Add(pl);
                ctx.SaveChanges();
            }
        }
    }
}
