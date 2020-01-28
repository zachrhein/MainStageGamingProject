//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Net.Http;
//using System.Threading.Tasks;

//namespace MainStageGamingProject.Models
//{
//    public class ApiHandler
//    {
//        public static async string GetRequest(string url)
//        {

//            using (HttpResponseMessage response = await APIHelper.ApiClient.GetAsync(url))
//            {
//                if (response.IsSuccessStatusCode)
//                {
//                    string epicObject = await response.Content.ReadAsAsync<string >();

//                    return epicObject;
//                }
//                else
//                {
//                    throw new Exception(response.ReasonPhrase);
//                }
//            }
//}


   //         using (HttpResponseMessage response = await APIHelper.ApiClient.GetAsync(url))
   //         {
   //             if (response.IsSuccessStatusCode)
   //             {
   //                 EpicNameModel epicObject = await response.Content.ReadAsAsync<EpicNameModel>(); this is getting stats using the userID

   //     return epicObject;
   // }
   // else
   // {
   // throw new Exception(response.ReasonPhrase);
   // }
   //} 
