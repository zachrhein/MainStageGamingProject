using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MainStageGamingProject.Models
{
    public class GlobalStats
    {
        public List<EpicStatsModel> Global_Stats { get; set; }
    }
    public class EpicStatsModel
    {
        public List<Object> Global_Stats { get; set; }
        public List<Object> Solo { get; set; }
        public List<Object> Duo { get; set; }
        public List<Object> Squad { get; set; }
        public string PlaceTop1 { get; set; }
        public string Kd { get; set; }
        public string WinRate { get; set; }
        public string Kills { get; set; }
        public string MatchesPlayed { get; set; }
        public string Score { get; set; }
    }

}
