﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MainStageGamingProject.Models
{
    public class Rootobject
    {

    }
    public class EpicStatsModel
    {
        //public Dictionary<string, Dictionary<string, string>> Global_Stats { get; set; }
        public Object Global_Stats { get; set; }
        public string Name { get; set; }
        //public string Solo { get; set; }
        //public string Duo { get; set; }
        //public string Squad { get; set; }
        //public string PlaceTop1 { get; set; }
        //public string Kd { get; set; }
        //public string WinRate { get; set; }
        //public string Kills { get; set; }
        //public string MatchesPlayed { get; set; }
        //public string Score { get; set; }
    }

}
