namespace EmpowerYourTeam.Utils
{
    public interface ITextBuilder
    { 
        /// <summary>
        /// Returns the text ready to be used on a prompt
        /// </summary>
        string Build();
    }
}