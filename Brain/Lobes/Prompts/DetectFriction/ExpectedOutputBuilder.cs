using EmpowerYourTeam.Utils;

namespace EmpowerYourTeam.Brain.Lobes.PromptBuilders.DetectFriction
{
    internal class ExpectedOutputBuilder
    {
        public static string Build()
            => "Please try to detect any kind of friction, misunderstandings or misbehavior in the meeting." +
               "Identify who was involved and provide a summary of the behavior that was incorrect, towards who, and suggest behavior improvements." +
               "Please have into consideration the time of the day and the personality traits of each team member in order to provide an accurate response";
    }
}
