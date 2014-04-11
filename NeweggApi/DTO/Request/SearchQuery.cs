using System.Net.Http;

namespace NeweggApi.DTO.Request
{
    public class SearchQuery : ApiRequest
    {
        public SearchQuery() : base("/Search.egg/Query", HttpMethod.Post)
        {
            PageNumber = 1;
            NodeId = -1;
            CategoryId = -1;
            BrandId = -1;
            StoreId = -1;
            StoreType = -1;
            SubCategoryId = -1;
        }

        public object[] BrandList { get; set; }
        public object[] SearchProperties { get; set; }
        public string Keyword { get; set; }
        public string MaxPrice { get; set; }
        public string MinPrice { get; set; }
        public string ModuleParams { get; set; }
        public string NValue { get; set; }
        public object[] ProductType { get; set; }
        public int PageNumber { get; set; }
        public int NodeId { get; set; }
        public int CategoryId { get; set; }
        public int BrandId { get; set; }
        public int StoreId { get; set; }
        public int StoreType { get; set; }
        public int SubCategoryId { get; set; }
    }
}