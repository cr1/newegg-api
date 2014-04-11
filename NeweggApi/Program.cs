using System;
using NeweggApi.DTO.Request;
using NeweggApi.DTO.Response;
using NeweggApi.Http;

namespace NeweggApi
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your search keyword");
            var search = new SearchQuery() {Keyword = Console.ReadLine()};
            var searchResponse = ApiCall.Send<SearchResponse>(search);
            if (searchResponse.ProductGroups[0].PageInfo.TotalCount > 0)
            {
                var item = searchResponse.ProductGroups[0].ProductDeals[0];
                var itemNumber = item.ItemNumber;
                Console.WriteLine("Top Result: {0} ({1})", item.Title, item.ItemNumber);
                var productSpecs = new ProductQuery(itemNumber, RequestType.Specification);
                var productDetail = new ProductQuery(itemNumber, RequestType.Detail);
                var productReviews = new ProductQuery(itemNumber, RequestType.ReviewsInfo);
                var specsResponse = ApiCall.Send<ProductSpecificationResponse>(productSpecs);
                if (specsResponse.NeweggItemNumber == item.NeweggItemNumber)
                {
                    Console.WriteLine("{0} : {1}", specsResponse.SpecificationGroupList[0].SpecificationPairList[0].Key, specsResponse.SpecificationGroupList[0].SpecificationPairList[0].Value);
                }
                var detailResponse = ApiCall.Send<ProductDetailResponse>(productDetail);
                if (detailResponse.Basic.ItemNumber == item.ItemNumber) 
                {
                    Console.WriteLine(detailResponse.Additional.Model);
                }
                var reviewResponse = ApiCall.Send<ProductReviewResponse>(productReviews);
                if (reviewResponse.Summary != null)
                {
                    Console.WriteLine("{0} rating, {1} reviews", reviewResponse.Summary.Rating, reviewResponse.Summary.TotalReviews);
                }

            }


            Console.ReadLine();


        }
    }
}