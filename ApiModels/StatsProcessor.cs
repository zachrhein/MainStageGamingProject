using MainStageGamingProject.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace MainStageGamingProject.ApiModels
{
    
    public class StatsProcessor
    {

        // Get player stats
        public async Task<EpicStatsModel> LoadStats(EpicNameModel epicNameModel)
            //returning 0 right now, need to pass a string as a parameter to convert username to their user id to check their stats.
        {
            HttpClient httpClient = new HttpClient();
            string url = $"https://fortniteapi.io/stats?account={epicNameModel.Account_id}";
            httpClient.DefaultRequestHeaders.Add("Authorization", "0e235bf6-1954f433-5e4caaf7-f6deb034");
            
                try
                {
                
                HttpResponseMessage response = await httpClient.GetAsync(url);
                EpicStatsModel stats = await response.Content.ReadAsAsync<EpicStatsModel>();
                //response.Content = json
                //RootObject stats = //JsonConvert.DeserializeObject<RootObject>(response.Content);

                return stats;
                }
                catch (HttpRequestException)
                {
                return new EpicStatsModel();
                }          
        }  

    }
}
