using System.Net.Http;

namespace NeweggApi.DTO.Request
{
    public class PromotionQuery : ApiRequest
    {
        public PromotionQuery(PromotionRequestType type) :base("Promotions.egg/{0}", HttpMethod.Get)
        {
            base.ApiUrl = string.Format(base.ApiUrl, type);
        }
    }
    public enum PromotionRequestType
    {
        NewShellShocker,
        Spotlights,
        Banners,
        DailyDeal,
        ExclusiveDeals
    }
}
