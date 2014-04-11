using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;

namespace NeweggApi.DTO.Request
{
    public class StoreQuery : ApiRequest
    {
        public StoreQuery(StoreRequestType type, int store = 1, int category = -1, int node = -1, int storeTypeId = 4, int page = 1) :base("Stores.egg/{0}?{1}", HttpMethod.Get)
        {
            storeId = store;
            categoryId = category;
            nodeId = node;
            storeType = storeTypeId;
            pageNumber = page;
            var urlParams = this.GetType().GetProperties().Where(e => e.PropertyType == typeof(int)).Select(x => x.Name + "=" + x.GetValue(this, null)).ToArray();
            base.ApiUrl = string.Format(base.ApiUrl, type, string.Join("&", urlParams));

        }
        public int storeId { get; set; }
        public int categoryId { get; set; }
        public int nodeId { get; set; }
        public int storeType { get; set; }
        public int pageNumber { get; set; } 


    }
    public enum StoreRequestType
    {
        storeNavigation,
        Content
    }
}
