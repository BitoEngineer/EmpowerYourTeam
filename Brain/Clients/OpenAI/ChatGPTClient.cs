using EmpowerYourTeam.Brain.Clients.OpenAI.DTO;
using System.Text;
using System.Text.Json;

namespace EmpowerYourTeam.Brain.Clients.OpenAI
{
    public class ChatGPTClient : IAIClient
    {
        private const string API_TOKEN = "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";
        private const string MODEL = "gpt-3.5-turbo";

        private static HttpClient _httpClient = new HttpClient();

        public async Task<string> GetAnswer(string promptTxt)
        {
            ChatCompletionInput requestData = CreateInput(promptTxt);
            var jsonContent = JsonSerializer.Serialize(requestData);
            var httpContent = new StringContent(jsonContent, Encoding.UTF8, "application/json");

            _httpClient.DefaultRequestHeaders.Add("Authorization", $"Bearer {API_TOKEN}");
            var response = await _httpClient.PostAsync("generate", httpContent);
            var responseTxt = await response.Content.ReadAsStringAsync();

            if (!response.IsSuccessStatusCode)
            {
                throw new Exception($"Some unexpected problem occured invoing ChatGPT: {responseTxt}");
            }

            return JsonSerializer.Deserialize<ChatCompletionOutput>(responseTxt)?.Choices.FirstOrDefault()?.Message?.Content
                    ?? throw new Exception($"ChatGPT is becoming dumb, didn't provide an answer. \n {responseTxt}");
        }

        private static ChatCompletionInput CreateInput(string promptTxt)
        {
            return new ChatCompletionInput
            {
                Model = MODEL,
                Messages = new Message[]
                {
                    new Message
                    {
                        Role = "system",
                        Content = promptTxt
                    }
                }
            };
        }
    }
}
