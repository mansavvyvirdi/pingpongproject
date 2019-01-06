using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Text;

namespace PingPongDataEntities
{
    public class PingPongDBInitializer : DropCreateDatabaseIfModelChanges<PingpongContext>
    {
        protected override void Seed(PingpongContext context)
        {
            List<SkillLevel> skillLevels = new List<SkillLevel>();

            skillLevels.Add(new SkillLevel() { SkillLevelName = "Beginner" });
            skillLevels.Add(new SkillLevel() { SkillLevelName = "Intermediate" });
            skillLevels.Add(new SkillLevel() { SkillLevelName = "Advanced" });
            skillLevels.Add(new SkillLevel() { SkillLevelName = "Expert" });

            context.SkillLevels.AddRange(skillLevels);

            base.Seed(context);
        }
    }
}
