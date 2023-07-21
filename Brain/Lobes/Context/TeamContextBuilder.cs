using EmpowerYourTeam.Domain.DevelopmentTeam;
using EmpowerYourTeam.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpowerYourTeam.Brain.Lobes.ContextBuilders
{
    /// <summary>
    /// Creates the all the proper context for a given team to give as an input for a prompt
    /// </summary>
    public class TeamContextBuilder
    {

        public static string Build(Team team)
            => $"The team {team.Name} exists since {team.Birthday}. {team.Description}." +
               $"It's composed by {string.Join(", ", team.Members.Select(m => $"{m.Name} (the {m.Role})"))}." +
               $"{string.Join(", ", team.Members.Select(m => TeamMemberContextBuilder.Build(m)))}";
    }
}
