namespace NeweggApi.DTO.Response
{

    public class ProductReviewResponse
    {
        public Ipadreview[] IpadReviews { get; set; }
        public Reviewsummaryinfo ReviewSummaryInfo { get; set; }
        public Summary Summary { get; set; }
        public object Reviews { get; set; }
        public Paginationinfo PaginationInfo { get; set; }
        public Productimageinfo ProductImageInfo { get; set; }
        public Productreviewbarinfo ProductReviewBarInfo { get; set; }
    }

    public class Reviewsummaryinfo
    {
        public int Last2WeeksCount { get; set; }
        public object Last2WeeksDesc { get; set; }
        public int Last6MonthsCount { get; set; }
        public object Last6MonthsDesc { get; set; }
        public int AllReviewCount { get; set; }
        public object AllReviewDesc { get; set; }
    }

    public class Summary
    {
        public int Rating { get; set; }
        public string TotalReviews { get; set; }
    }

    public class Paginationinfo
    {
        public int TotalCount { get; set; }
        public int PageSize { get; set; }
        public int PageNumber { get; set; }
        public int PageCount { get; set; }
        public object PageNumberList { get; set; }
    }

    public class Productimageinfo
    {
        public object Title { get; set; }
        public string FullPath { get; set; }
        public object ThumbnailImagePath { get; set; }
        public object SmallImagePath { get; set; }
        public object PathSize35 { get; set; }
        public object PathSize60 { get; set; }
        public object PathSize100 { get; set; }
        public object PathSize125 { get; set; }
        public object PathSize180 { get; set; }
        public object PathSize300 { get; set; }
        public object PathSize640 { get; set; }
    }

    public class Productreviewbarinfo
    {
        public int RatingCounts { get; set; }
        public string Rating1Count { get; set; }
        public int Rating1Percent { get; set; }
        public string Rating2Count { get; set; }
        public int Rating2Percent { get; set; }
        public string Rating3Count { get; set; }
        public int Rating3Percent { get; set; }
        public string Rating4Count { get; set; }
        public int Rating4Percent { get; set; }
        public string Rating5Count { get; set; }
        public int Rating5Percent { get; set; }
    }

    public class Ipadreview
    {
        public int BoughtTimeTypeInt { get; set; }
        public int TechLevelTypeInt { get; set; }
        public int reviewID { get; set; }
        public string Title { get; set; }
        public int Rating { get; set; }
        public string PublishDate { get; set; }
        public string LoginNickName { get; set; }
        public string BoughtTimeTypeString { get; set; }
        public string TechLevelTypeString { get; set; }
        public bool IsNewReview { get; set; }
        public bool PurchaseMark { get; set; }
        public string Cons { get; set; }
        public string Pros { get; set; }
        public string Comments { get; set; }
        public int TotalConsented { get; set; }
        public int TotalVoting { get; set; }
    }

}
