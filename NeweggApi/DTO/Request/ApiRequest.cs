using System.Net.Http;

namespace NeweggApi.DTO.Request
{
    public interface IApiRequest
    {
         string ApiUrl { get; set; }
         HttpMethod HttpMethod { get; set; }
    }
    public class ApiRequest : IApiRequest
    {
        public ApiRequest(string url, HttpMethod method)
        {
            ApiUrl = url;
            HttpMethod = method;
        }
        public string ApiUrl { get; set; }
        public HttpMethod HttpMethod { get; set; }
    }
}
