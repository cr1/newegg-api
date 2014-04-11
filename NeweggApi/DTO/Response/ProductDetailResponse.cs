namespace NeweggApi.DTO.Response
{

    public class ProductDetailResponse
    {
        public Basic Basic { get; set; }
        public Additional Additional { get; set; }
        public bool ContainComboDeals { get; set; }
        public Shoppinginsight ShoppingInsight { get; set; }
        public Coremetricsinfo CoremetricsInfo { get; set; }
        public Crosstable CrossTable { get; set; }
        public Similar Similar { get; set; }
        public Returnpolicy ReturnPolicy { get; set; }
        public bool HideFeedBack { get; set; }
        public object SuggestSimilarContent { get; set; }
    }

    public class Basic
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
        public object SellerInfo { get; set; }
        public Itembrand ItemBrand { get; set; }
        public Itemimage[] ItemImages { get; set; }
        public object EggPointInfo { get; set; }
    }



    public class Additional
    {
        public bool IsShellShockerItem { get; set; }
        public bool CanPriceAlert { get; set; }
        public int LimitQuantity { get; set; }
        public object[] Warnings { get; set; }
        public object FreeGifts { get; set; }
        public object VolumeDiscounts { get; set; }
        public object ProductProperties { get; set; }
        public Category Category { get; set; }
        public object MailInRebates { get; set; }
        public string Model { get; set; }
        public Emailfriendimageinfo EmailFriendImageInfo { get; set; }
        public Shippinghelp ShippingHelp { get; set; }
        public object IronEgg { get; set; }
        public string StockDescription { get; set; }
        public string PromotionCode { get; set; }
    }

    public class Category
    {
        public int SubCategoryId { get; set; }
        public string SubCategoryName { get; set; }
    }

    public class Emailfriendimageinfo
    {
        public object ItemNumber { get; set; }
        public object Title { get; set; }
        public string FullPath { get; set; }
        public string ThumbnailImagePath { get; set; }
        public string SmallImagePath { get; set; }
        public string PathSize35 { get; set; }
        public string PathSize60 { get; set; }
        public string PathSize100 { get; set; }
        public string PathSize125 { get; set; }
        public string PathSize180 { get; set; }
        public string PathSize300 { get; set; }
        public string PathSize640 { get; set; }
    }

    public class Shippinghelp
    {
        public string Summry { get; set; }
        public string Content { get; set; }
    }

    public class Shoppinginsight
    {
        public string Description { get; set; }
        public Promotionitem[] PromotionItems { get; set; }
    }

    public class Promotionitem
    {
        public string Percentage { get; set; }
        public bool IsCurrentItem { get; set; }
        public object StoreNavigation { get; set; }
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
        public Reviewsummary1 ReviewSummary { get; set; }
        public bool IsHot { get; set; }
        public object SellerInfo { get; set; }
        public object ItemBrand { get; set; }
        public Itemimage1[] ItemImages { get; set; }
        public object EggPointInfo { get; set; }
    }

    public class Reviewsummary1
    {
        public int Rating { get; set; }
        public string TotalReviews { get; set; }
    }

    public class Itemimage1
    {
        public object Title { get; set; }
        public object FullPath { get; set; }
        public object ThumbnailImagePath { get; set; }
        public object SmallImagePath { get; set; }
        public string PathSize35 { get; set; }
        public string PathSize60 { get; set; }
        public string PathSize100 { get; set; }
        public string PathSize125 { get; set; }
        public string PathSize180 { get; set; }
        public string PathSize300 { get; set; }
        public string PathSize640 { get; set; }
    }



    public class Crosstable
    {
        public Drivesaver[] DriveSavers { get; set; }
        public Extendedwarranty1[] ExtendedWarranties { get; set; }
        public object ManufactureService { get; set; }
    }

    public class Drivesaver
    {
        public string GroupName { get; set; }
        public string GroupDescription { get; set; }
        public Extendedwarranty[] ExtendedWarranties { get; set; }
    }

    public class Extendedwarranty
    {
        public Image Image { get; set; }
        public string ItemNumber { get; set; }
        public object Description { get; set; }
        public int Years { get; set; }
        public bool PreSelected { get; set; }
        public string FinalPrice { get; set; }
        public string OriginalPrice { get; set; }
        public object SavingText { get; set; }
        public string PopMessage { get; set; }
    }

    public class Image
    {
        public object Title { get; set; }
        public object FullPath { get; set; }
        public object ThumbnailImagePath { get; set; }
        public object SmallImagePath { get; set; }
        public object PathSize35 { get; set; }
        public object PathSize60 { get; set; }
        public object PathSize100 { get; set; }
        public string PathSize125 { get; set; }
        public object PathSize180 { get; set; }
        public object PathSize300 { get; set; }
        public object PathSize640 { get; set; }
    }

    public class Extendedwarranty1
    {
        public string GroupName { get; set; }
        public string GroupDescription { get; set; }
        public Extendedwarranty2[] ExtendedWarranties { get; set; }
    }

    public class Extendedwarranty2
    {
        public Image1 Image { get; set; }
        public string ItemNumber { get; set; }
        public string Description { get; set; }
        public int Years { get; set; }
        public bool PreSelected { get; set; }
        public string FinalPrice { get; set; }
        public string OriginalPrice { get; set; }
        public object SavingText { get; set; }
        public string PopMessage { get; set; }
    }

    public class Image1
    {
        public object ItemNumber { get; set; }
        public object Title { get; set; }
        public string FullPath { get; set; }
        public string ThumbnailImagePath { get; set; }
        public string SmallImagePath { get; set; }
        public string PathSize35 { get; set; }
        public string PathSize60 { get; set; }
        public string PathSize100 { get; set; }
        public string PathSize125 { get; set; }
        public string PathSize180 { get; set; }
        public string PathSize300 { get; set; }
        public string PathSize640 { get; set; }
    }

    public class Similar
    {
        public string ModuleParams { get; set; }
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

    public class Returnpolicy
    {
        public string Name { get; set; }
        public string ID { get; set; }
        public string HtmlContent { get; set; }
        public bool IsSeller { get; set; }
    }

}
