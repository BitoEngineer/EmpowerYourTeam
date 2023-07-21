namespace EmpowerYourTeam.Brain.Clients
{
    public interface IAIClient
    {
        Task<string> GetAnswer(string promptTxt);
    }
}
