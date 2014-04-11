namespace NeweggApi.DTO.Response
{

    public class ProductSpecificationResponse
    {
        public string NeweggItemNumber { get; set; }
        public string Title { get; set; }
        public Specificationgrouplist[] SpecificationGroupList { get; set; }
    }

    public class Specificationgrouplist
    {
        public string GroupName { get; set; }
        public Specificationpairlist[] SpecificationPairList { get; set; }
    }

    public class Specificationpairlist
    {
        public string Key { get; set; }
        public string Value { get; set; }
    }

}
