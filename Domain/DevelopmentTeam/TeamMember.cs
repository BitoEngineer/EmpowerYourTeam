using EmpowerYourTeam.Domain.DevelopmentTeam;
using EmpowerYourTeam.Domain.Human;

namespace EmpowerYourTeam.Domain.Team
{
    public class TeamMember
    {
        public string Name { get; set; }
        public string Role { get; set; }
        public int TotalDaysInTheTeam { get; set; }
        public Seniority Seniority { get; set; }

        public Personality Personality { get; set; }
    }
}
