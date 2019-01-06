using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Text;

namespace PingPongDataEntities
{
    public class PingpongContext : DbContext
    {
        public PingpongContext() : base("PingpongDB")
        {
            //Disable initializer
            //Database.SetInitializer<PingpongContext>(null);
            //Database.SetInitializer<PingpongContext>(new CreateDatabaseIfNotExists<PingpongContext>());

            //Database.SetInitializer<PingpongContext>(new DropCreateDatabaseIfModelChanges<PingpongContext>());
            //Database.SetInitializer<PingpongContext>(new DropCreateDatabaseAlways<PingpongContext>());
            Database.SetInitializer(new PingPongDBInitializer());
        }



        public DbSet<Player> Players { get; set; }
        public DbSet<SkillLevel> SkillLevels { get; set; }
    }
}
