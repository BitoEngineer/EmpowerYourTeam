namespace EmpowerYourTeam.Brain.Clients.OpenAI.DTO
{
    public class ChatCompletionInput
    {
        public string Model { get; set; } = string.Empty;
        public Message[] Messages { get; set; } = Array.Empty<Message>();
    }
}
