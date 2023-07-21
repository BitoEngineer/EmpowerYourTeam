using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpowerYourTeam.Domain.Meetings
{
    public class Meeting
    {
        public Transcript Transcript { get; set; }
        public int DurationMinutes { get; set; }
        public PartOfTheDay PartOfTheDay { get; set; }
    }
}
