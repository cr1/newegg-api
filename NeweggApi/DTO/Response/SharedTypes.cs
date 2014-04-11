namespace NeweggApi.DTO.Response
{
    public class Reviewsummary
    {
        public int Rating { get; set; }
        public string TotalReviews { get; set; }
    }

    public class Itembrand
    {
        public int Code { get; set; }
        public int BrandId { get; set; }
        public string Description { get; set; }
        public string ManufactoryWeb { get; set; }
        public object WebSiteURL { get; set; }
        public bool HasManfactoryLogo { get; set; }
        public string BrandImage { get; set; }
    }

    public class Productgroup
    {
        public object GroupName { get; set; }
        public object SeeAllNavigation { get; set; }
        public Productdeal[] ProductDeals { get; set; }
        public Pageinfo PageInfo { get; set; }
        public Coremetricsinfo CoremetricsInfo { get; set; }
    }

    public class Itemimage
    {
        public object ItemNumber { get; set; }
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
    public class Coremetricsinfo
    {
        public string CategoryID { get; set; }
        public string ProductName { get; set; }
        public string PageID { get; set; }
        public string Brand { get; set; }
    }
}
