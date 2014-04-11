using System.Net.Http;

namespace NeweggApi.DTO.Request
{
    public class CompareQuery : ApiRequest
    {
        public CompareQuery() :base("Compare.egg/Index/", HttpMethod.Post)
        {
        }

        public string[] ItemList { get; set; }
        public bool IsMasterComboCompare { get; set; }
        public int StoreId { get; set; }
    }
}
