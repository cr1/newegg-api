using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NeweggApi.DTO.Response;

namespace NeweggApi.Extensions
{
    public static class ProductExtensions
    {
        public static string GetSpecificationValue(this ProductSpecificationResponse obj, string key)
        {
            var pair = obj.SpecificationGroupList.SelectMany(x => x.SpecificationPairList).FirstOrDefault(y => y.Key == key);
            return pair != null ? pair.Value : String.Empty;
        }
    }
}
