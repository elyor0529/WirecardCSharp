using Newtonsoft.Json;

namespace WirecardCSharp.Models
{
    public class Item
    {
        [JsonProperty("product", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Product { get; set; }
        [JsonProperty("category", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Category { get; set; }
        [JsonProperty("quantity", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public int Quantity { get; set; }
        [JsonProperty("detail", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Detail { get; set; }
        [JsonProperty("price", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public int Price { get; set; }
    }
}