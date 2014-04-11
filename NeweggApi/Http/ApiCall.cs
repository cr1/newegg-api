using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using NeweggApi.DTO.Request;
using Newtonsoft.Json;

namespace NeweggApi.Http
{
    public static class ApiCall
    {
        public const string RootUrl = "http://www.ows.newegg.com/";
        public static T Send<T>(IApiRequest request)
        {
            using (var client = new WebClient())
            {
                client.BaseAddress = RootUrl;
                string jsonResponse = String.Empty;
                if (request.HttpMethod.Equals(HttpMethod.Get))
                {
                    jsonResponse = client.DownloadString(request.ApiUrl);
                }
                if (request.HttpMethod.Equals(HttpMethod.Post))
                {
                    var jsonRequest = JsonConvert.SerializeObject(request);
                    jsonResponse = client.UploadString(request.ApiUrl, jsonRequest);
                }
                var dto = JsonConvert.DeserializeObject<T>(jsonResponse);
                return dto;
            }

            
        }
    }
}
