using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeweggApi.DTO.Response
{

    public class StoreContentResponse
    {
        public Modulebanner[] ModuleBanners { get; set; }
        public Productgroup[] ProductGroups { get; set; }
    }

    public class Modulebanner
    {
        public int BannerType { get; set; }
        public object TextLine { get; set; }
        public string ModuleName { get; set; }
        public Imagebanner ImageBanner { get; set; }
        public object ItemsBanner { get; set; }
    }

    public class Imagebanner
    {
        public string BannerImageUrl { get; set; }
        public string BannerResourceLink { get; set; }
        public Bannerresource BannerResource { get; set; }
    }

    public class Bannerresource
    {
        public int ItemType { get; set; }
        public object ItemNumber { get; set; }
        public object RelatedItemNumber { get; set; }
        public bool ShowSeeAllDeals { get; set; }
        public string CustomLink { get; set; }
        public object LinkParams { get; set; }
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



    public class Seeallnavigation
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








}
