using EmpowerYourTeam.Domain.Team;
using EmpowerYourTeam.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpowerYourTeam.Brain.Lobes.ContextBuilders
{
    public class TeamMemberContextBuilder
    {
        public static string Build(TeamMember _member)
            => $"{_member.Name} is a {_member.Seniority} {_member.Role} that joined the team {_member.TotalDaysInTheTeam} days ago." +
               $"The personality traits evaluation of this team member is the following: {PersonalityContextBuilder.Build(_member.Personality)}.";
    }
}
