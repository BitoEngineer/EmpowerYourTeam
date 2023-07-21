using EmpowerYourTeam.Utils;

namespace EmpowerYourTeam.Brain.Lobes.Memory
{
    public class PersonalityTraitsMeaningBuilder
    {
        public static string Build()
            => string.Format("Consider that the meaning of each personality trait that's used to describe the team member personality is: {0}" +
               $"The evaluation is done from 0 to 10, where 0 is Very Low and 10 is Very High.", File.ReadAllText("./Lobes/Memory/PersonalityTraitsMeaning.txt"));
    }
}
