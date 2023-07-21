using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpowerYourTeam.Domain.Meetings
{
    public class Talk
    {
        public string MemberName { get; set; }
        public string Text { get; set; }
        public DateTime Timestamp { get; set; }
        public TimeSpan Duration { get; set; }
    }
}
