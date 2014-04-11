# C# Newegg API
This API was built to pull product information and reviews from Newegg. Thanks to [bemasher](https://github.com/bemasher/NeweggMobileAPI) for finding this service.

## Currently supported:
- Product Search
- Product Detail, Specification, and Reviews
- Product Comparison

## Not implemented yet:
- Navigation
- Promotions / Daily Deals
- Easy to use search method
- Easy to use response methods

### Example

			var search = new SearchQuery() {Keyword = Console.ReadLine()};
            var searchResponse = ApiCall.Send<SearchResponse>(search);
            if (searchResponse.ProductGroups[0].PageInfo.TotalCount > 0)
            {
                var item = searchResponse.ProductGroups[0].ProductDeals[0];
				var productDetail = new ProductQuery(item.ItemNumber, RequestType.Detail);
				var detailResponse = ApiCall.Send<ProductDetailResponse>(productDetail);
			}