using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeweggApi.DTO.Response
{

    public class PromotionShellShockerResponse
    {
        public Class1[] Property1 { get; set; }
    }

    public class Class1
    {
        public int ShellShockerStatusType { get; set; }
        public string UpComingDeal { get; set; }
        public string UpComingTime { get; set; }
        public string CurrentTimeZone { get; set; }
        public bool IsWhatsHot { get; set; }
        public string LogoImageUrl { get; set; }
        public object PromotionCode { get; set; }
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







}
