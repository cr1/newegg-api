using System.Net.Http;

namespace NeweggApi.DTO.Request
{
    
    public class ProductQuery : ApiRequest

    {
        public ProductQuery(string id, ProductRequestType type) :base("Products.egg/{0}/{1}", HttpMethod.Get)
        {
            ProductId = id;
            Type = type;
            base.ApiUrl = string.Format(base.ApiUrl, ProductId, Type);
        }
        public string ProductId { get; set; }
        public ProductRequestType Type { get; set; }

    }
    public enum ProductRequestType
    {
        Specification,
        Detail,
        ReviewsInfo
    }
}
