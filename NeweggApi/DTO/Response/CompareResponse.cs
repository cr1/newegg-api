using System;

namespace NeweggApi.DTO.Response
{

    public class CompareResponse
    {
        public Product[] Products { get; set; }
        public string[][] LeftHeaderData { get; set; }
        public string[][][] Data { get; set; }
        public object[] SectionHeaderData { get; set; }
    }

    public class Product
    {
        public object ReturnPolicyInfo { get; set; }
        public object MailInRebateInfo { get; set; }
        public object imageGallery { get; set; }
        public object ShippingInfo { get; set; }
        public bool IsShowSoldOutText { get; set; }
        public string AddToCartButtonText { get; set; }
        public string AddToCartButtonType { get; set; }
        public object CoremetricsInfo { get; set; }
        public object EmailFriendImageInfo { get; set; }
        public object ShippingPromotionInfo { get; set; }
        public bool IsActivated { get; set; }
        public object SellerItemPropertyList { get; set; }
        public bool IsShowEnergyStarSection { get; set; }
        public object EnergyStarText { get; set; }
        public object IronEggDescription { get; set; }
        public object IronEggImageLink { get; set; }
        public int ComboCount { get; set; }
        public int SubCategoryId { get; set; }
        public object SubCategoryName { get; set; }
        public object Warnings { get; set; }
        public bool IsShipByNewegg { get; set; }
        public object ShoppingInsight { get; set; }
        public object ProductProperties { get; set; }
        public object EduHelpInfo { get; set; }
        public object PromotionCode { get; set; }
        public object EggPointInfo { get; set; }
        public bool IsCellPhoneItem { get; set; }
        public bool ShowOriginalPrice { get; set; }
        public object MailInRebateText { get; set; }
        public bool IsComboBundle { get; set; }
        public int ProductStockType { get; set; }
        public object MappingFinalPrice { get; set; }
        public bool IsFeaturedItem { get; set; }
        public bool IsMicrosoftDownloadItem { get; set; }
        public bool IsProductKeyOnly { get; set; }
        public string Title { get; set; }
        public string OriginalPrice { get; set; }
        public object Discount { get; set; }
        public string FinalPrice { get; set; }
        public bool FreeShippingFlag { get; set; }
        public object Model { get; set; }
        public Reviewsummary ReviewSummary { get; set; }
        public Image Image { get; set; }
        public object SellerName { get; set; }
        public object ParentItem { get; set; }
        public object SellerId { get; set; }
        public int ShipByNewegg { get; set; }
        public int ItemGroupID { get; set; }
        public int ItemOwnerType { get; set; }
        public int NumberOfReviews { get; set; }
        public int AverageRating { get; set; }
        public bool Instock { get; set; }
        public object XmlSpec { get; set; }
        public Warrantyinfo WarrantyInfo { get; set; }
        public string NeweggItemNumber { get; set; }
        public object PromotionInfo { get; set; }
        public bool InstockForCombo { get; set; }
        public DateTime ETA { get; set; }
        public bool IsInPMCC { get; set; }
        public bool CanAddToCart { get; set; }
        public object StrCartImg { get; set; }
        public object StrAlt { get; set; }
        public object StrAddItem { get; set; }
        public object StaticText { get; set; }
        public float InstantSaving { get; set; }
        public bool HasMappingPrice { get; set; }
        public float UnitPrice { get; set; }
        public object BrandInfo { get; set; }
        public int LimitQuantity { get; set; }
        public bool IsShellShockerItem { get; set; }
        public string PromotionText { get; set; }
        public int ItemMapPriceMarkType { get; set; }
        public bool IsHot { get; set; }
        public bool IsPreLaunch { get; set; }
        public string ItemNumber { get; set; }
        public bool Academic { get; set; }
    }

    public class Warrantyinfo
    {
        public int WarrantyID { get; set; }
        public string WarrantyName { get; set; }
    }

}
