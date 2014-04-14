using System;
using System.Linq;
using NeweggApi.DTO.Response;

namespace NeweggApi.Extensions
{
    public static class ProductExtensions
    {
        public static string GetSpecificationValue(this ProductSpecificationResponse obj, string key)
        {
            var pair = obj.SpecificationGroupList.SelectMany(x => x.SpecificationPairList).FirstOrDefault(y => y.Key == key);
            return pair != null ? pair.Value : null;
        }
    }
}
