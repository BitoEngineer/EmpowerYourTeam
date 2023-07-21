using EmpowerYourTeam.Domain.Human;
using EmpowerYourTeam.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpowerYourTeam.Brain.Lobes.ContextBuilders
{
    public class PersonalityContextBuilder
    {
        public static string Build(Personality personality)
            => string.Join("\n", personality.GetType().GetProperties()
                   .Select(p => $"{p.Name}:{p.GetValue(personality)}"));
    }
}
