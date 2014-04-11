using System;
using NeweggApi.DTO.Request;
using NeweggApi.DTO.Response;
using NeweggApi.Http;
using NeweggApi.Extensions;

namespace NeweggApi
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your search keyword");

            //var storeQuery = new StoreQuery(StoreRequestType.Content);
            //var results = ApiCall.Send<StoreContentResponse>(storeQuery);
            //Console.ReadLine();

            var search = new SearchQuery() {Keyword = Console.ReadLine()};
            var searchResponse = ApiCall.Send<SearchResponse>(search);
            if (searchResponse.ProductGroups[0].PageInfo.TotalCount > 0)
            {
                var item = searchResponse.ProductGroups[0].ProductDeals[0];
                var itemNumber = item.ItemNumber;
                Console.WriteLine("Top Result: {0} ({1})", item.Title, item.FinalPrice);
                var productSpecs = new ProductQuery(itemNumber, ProductRequestType.Specification);
                var productDetail = new ProductQuery(itemNumber, ProductRequestType.Detail);
                var productReviews = new ProductQuery(itemNumber, ProductRequestType.ReviewsInfo);
                var specsResponse = ApiCall.Send<ProductSpecificationResponse>(productSpecs);
                if (specsResponse.NeweggItemNumber == item.NeweggItemNumber)
                {
                    Console.WriteLine("Brand: {0} : Model: {1}", specsResponse.GetSpecificationValue("Brand"), specsResponse.GetSpecificationValue("Model"));
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