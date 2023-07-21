using EmpowerYourTeam.Brain.Clients;
using EmpowerYourTeam.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpowerYourTeam.Brain
{
    public class Brain
    {

        private ITextBuilder _inputBuilder { get;set; }
        private IAIClient _aiClient { get; set; }

        public Brain(ITextBuilder inputBuilder, IAIClient aiClient)
        {
            _inputBuilder = inputBuilder;
            _aiClient = aiClient;
        }


        public async Task<string> GiveMeAnswers()
        {
            var promptTxt = _inputBuilder.Build();
            return await _aiClient.GetAnswer(promptTxt);
        }
    }
}
