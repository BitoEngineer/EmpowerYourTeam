using EmpowerYourTeam.Brain.Lobes.ContextBuilders;
using EmpowerYourTeam.Brain.Lobes.Memory;
using EmpowerYourTeam.Domain.DevelopmentTeam;
using EmpowerYourTeam.Domain.Meetings;
using EmpowerYourTeam.Utils;

namespace EmpowerYourTeam.Brain.Lobes.PromptBuilders.DetectFriction
{
    public class DetectTeamFrictionPromptBuilder : ITextBuilder
    {
        private Team _team;
        private List<Meeting> _meetings;

        public DetectTeamFrictionPromptBuilder(Team team, List<Meeting> meetings)
        {
            _team = team;
            _meetings = meetings;
        }

        public string Build()
        {
            var prompt = string.Join("\n",File.ReadAllLines("./Lobes/Prompts/DetectFriction/Prompts/detect-friction-prompt.txt"));
            return prompt.Replace("<<PeronalityTraitsMeaning>>", PersonalityTraitsMeaningBuilder.Build())
                         .Replace("<<TeamContext>>", TeamContextBuilder.Build(_team))
                         .Replace("<<MeetingContext>>", string.Join(",", _meetings.Select(m => MeetingContextBuilder.Build(m))))
                         .Replace("<<ExpectedOutput>>", ExpectedOutputBuilder.Build());
        }
    }
}
