namespace EmpowerYourTeam.Brain.Clients.OpenAI.DTO
{
    internal class ChatCompletionOutput
    {
        public List<Choice> Choices { get; set; } = new List<Choice>();
        public long Created { get; set; }
        public string Id { get; set; } = string.Empty;
        public string Model { get; set; } = string.Empty;
        public string Object { get; set; } = string.Empty;
        public Usage? Usage { get; set; }
    }

    public class Choice
    {
        public string FinishReason { get; set; } = string.Empty;
        public int Index { get; set; }
        public Message? Message { get; set; }
    }

    public class Usage
    {
        public int CompletionTokens { get; set; }
        public int PromptTokens { get; set; }
        public int TotalTokens { get; set; }
    }
}
