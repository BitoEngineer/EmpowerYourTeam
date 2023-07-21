//Task 1: Detect friction and misunderstandings in a team meeting
//Task 2: Suggest to a specific team member how to improve his communication with other team member
//Task 3: Validate if the team is focused on the road map on a daily basis
//Task 4: Detect if some team member should request or offer help based on the seniority


using EmpowerYourTeam.Brain;
using EmpowerYourTeam.Brain.Clients.OpenAI;
using EmpowerYourTeam.Brain.Lobes.PromptBuilders.DetectFriction;
using EmpowerYourTeam.Domain.DevelopmentTeam;
using EmpowerYourTeam.Domain.Meetings;
using Newtonsoft.Json;

Console.WriteLine("AI is the first real revolution");
await Task1();

async Task Task1()
{
    Console.WriteLine("Detect friction and misunderstandings in a team meeting");

    var team = JsonConvert.DeserializeObject<Team>(File.ReadAllText("../../../Mocks/Horizon.json"));
    var meetings = JsonConvert.DeserializeObject<Meeting[]>(File.ReadAllText("../../../Mocks/HorizonDailyMeetings.json"));
    var textBuilder = new DetectTeamFrictionPromptBuilder(team, meetings.ToList());
    var client = new ChatGPTClient();
    var brain = new Brain(textBuilder, client);
    var suggestion = brain.GiveMeAnswers();

    Console.WriteLine(suggestion.ToString());
}