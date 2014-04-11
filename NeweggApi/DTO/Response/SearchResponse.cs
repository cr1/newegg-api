namespace NeweggApi.DTO.Response
{

    public class SearchResponse
    {
        public object SearchNote { get; set; }
        public object SoldByOptions { get; set; }
        public Sortoption[] SortOptions { get; set; }
        public Navigationcontentlist[] NavigationContentList { get; set; }
        public bool CanCompare { get; set; }
        public bool CanPowerSearch { get; set; }
        public object PowerSearchParams { get; set; }
        public bool CanAdvanceSearch { get; set; }
        public int MasterComboStoreId { get; set; }
        public Productgroup[] ProductGroups { get; set; }
    }

    public class Sortoption
    {
        public bool Selected { get; set; }
        public string Text { get; set; }
        public string Value { get; set; }
        public int Counts { get; set; }
    }

    public class Navigationcontentlist
    {
        public Titleitem TitleItem { get; set; }
        public Navigationitemlist[] NavigationItemList { get; set; }
    }

    public class Titleitem
    {
        public object ElementValue { get; set; }
        public object CategoryDescription { get; set; }
        public bool Selected { get; set; }
        public string Description { get; set; }
        public int StoreType { get; set; }
        public int CategoryId { get; set; }
        public int StoreId { get; set; }
        public int SubCategoryId { get; set; }
        public int BrandId { get; set; }
        public string NValue { get; set; }
        public int ItemCount { get; set; }
        public int NodeId { get; set; }
        public string Keyword { get; set; }
    }

    public class Navigationitemlist
    {
        public object ElementValue { get; set; }
        public object CategoryDescription { get; set; }
        public bool Selected { get; set; }
        public string Description { get; set; }
        public int StoreType { get; set; }
        public int CategoryId { get; set; }
        public int StoreId { get; set; }
        public int SubCategoryId { get; set; }
        public int BrandId { get; set; }
        public string NValue { get; set; }
        public int ItemCount { get; set; }
        public int NodeId { get; set; }
        public string Keyword { get; set; }
    }

    public class Productgroup
    {
        public object GroupName { get; set; }
        public object SeeAllNavigation { get; set; }
        public Productdeal[] ProductDeals { get; set; }
        public Pageinfo PageInfo { get; set; }
        public Coremetricsinfo CoremetricsInfo { get; set; }
    }

    public class Pageinfo
    {
        public int TotalCount { get; set; }
        public int PageSize { get; set; }
        public int PageNumber { get; set; }
        public int PageCount { get; set; }
        public object PageNumberList { get; set; }
    }



    public class Productdeal
    {
        public int ProductStockType { get; set; }
        public bool CanAddToCart { get; set; }
        public string AddToCartText { get; set; }
        public bool IsFeaturedItem { get; set; }
        public bool CanAddToWishList { get; set; }
        public int ItemType { get; set; }
        public string ItemNumber { get; set; }
        public string NeweggItemNumber { get; set; }
        public string ParentItemNumber { get; set; }
        public string Title { get; set; }
        public string PromotionText { get; set; }
        public string OriginalPrice { get; set; }
        public string FinalPrice { get; set; }
        public string MappingFinalPrice { get; set; }
        public string SavingText { get; set; }
        public string ShippingText { get; set; }
        public bool IsFreeShipping { get; set; }
        public string RebateText { get; set; }
        public int ItemMapPriceMarkType { get; set; }
        public bool Instock { get; set; }
        public Reviewsummary ReviewSummary { get; set; }
        public bool IsHot { get; set; }
        public Sellerinfo SellerInfo { get; set; }
        public Itembrand ItemBrand { get; set; }
        public Itemimage[] ItemImages { get; set; }
        public Eggpointinfo EggPointInfo { get; set; }
    }



    public class Sellerinfo
    {
        public string SellerName { get; set; }
        public string SellerId { get; set; }
        public int Rating { get; set; }
        public int ReviewCount { get; set; }
    }



    public class Eggpointinfo
    {
        public object PointRate { get; set; }
        public string Points { get; set; }
        public object EggPointPopUpText { get; set; }
    }



}
