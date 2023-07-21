using EmpowerYourTeam.Domain.Team;

namespace EmpowerYourTeam.Domain.DevelopmentTeam
{
    public class Team
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime Birthday { get; set; }
        public List<TeamMember> Members { get; set; }

    }
}
