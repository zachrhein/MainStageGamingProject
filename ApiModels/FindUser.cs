using MainStageGamingProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;

namespace MainStageGamingProject.ApiModels
{
    public class FindUser
    {
       public string Username { get; set; }
        public FindUser()
        {

        }

        public FindUser(string username) {
            Username = username;
        }

        public async Task<EpicNameModel> FindUserID()
        {

            HttpClient httpClient = new HttpClient();
            string url = $"https://fortniteapi.io/lookup?username={Username}";
            httpClient.DefaultRequestHeaders.Add("Authorization", "0e235bf6-1954f433-5e4caaf7-f6deb034");

            try
            { HttpResponseMessage response = await httpClient.GetAsync(url);
                response.EnsureSuccessStatusCode();

                EpicNameModel epicObject = await response.Content.ReadAsAsync<EpicNameModel>(); 

                return epicObject;
            }
            catch(HttpRequestException)
            {
                    return new EpicNameModel();

            }
        }

        
    }
}
