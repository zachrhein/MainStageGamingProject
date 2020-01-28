using MainStageGamingProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;

namespace MainStageGamingProject.ApiModels
{
    public class News
    {

        public async Task<NewsModel> ShowNews()
        {
            HttpClient httpClient = new HttpClient();
            string url = $"https://fortniteapi.io/news?lang=en&type=br";
            httpClient.DefaultRequestHeaders.Add("Authorization", "0e235bf6-1954f433-5e4caaf7-f6deb034");

            try
            {
                HttpResponseMessage response = await httpClient.GetAsync(url);
                response.EnsureSuccessStatusCode();

                NewsModel news = await response.Content.ReadAsAsync<NewsModel>();

                return news;
            }
            catch (HttpRequestException)
            {
                return new NewsModel();

            }
        }
    }
}
