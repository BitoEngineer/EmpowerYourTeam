using EmpowerYourTeam.Domain.Meetings;
using EmpowerYourTeam.Utils;

namespace EmpowerYourTeam.Brain.Lobes.ContextBuilders
{
    public class MeetingContextBuilder
    {
        public static string Build(Meeting m)
            => $"This meeting occurred at {m.PartOfTheDay} during {m.DurationMinutes} minutes." +
               $"The transcript is the following:" +
               $"{string.Join("\n", m.Transcript.Talks.Select(t => $"[{t.Timestamp}] {t.MemberName}: {t.Text})"))}";

    }
}
