using System;
using Newtonsoft.Json;

namespace WirecardCSharp.Models
{
    public partial class Billingaddress
    {
        [JsonIgnore, Obsolete("Utilize a propriedade que inicia com a letra maiúscula. Essa deixará de existir a partir da versão 2.0.0.")]
        public string city { get => City; set => City = value; }
        [JsonIgnore, Obsolete("Utilize a propriedade que inicia com a letra maiúscula. Essa deixará de existir a partir da versão 2.0.0.")]
        public string district { get => District; set => District = value; }
        [JsonIgnore, Obsolete("Utilize a propriedade que inicia com a letra maiúscula. Essa deixará de existir a partir da versão 2.0.0.")]
        public string street { get => Street; set => Street = value; }
        [JsonIgnore, Obsolete("Utilize a propriedade que inicia com a letra maiúscula. Essa deixará de existir a partir da versão 2.0.0.")]
        public string streetNumber { get => StreetNumber; set => StreetNumber = value; }
        [JsonIgnore, Obsolete("Utilize a propriedade que inicia com a letra maiúscula. Essa deixará de existir a partir da versão 2.0.0.")]
        public string zipCode { get => ZipCode; set => ZipCode = value; }
        [JsonIgnore, Obsolete("Utilize a propriedade que inicia com a letra maiúscula. Essa deixará de existir a partir da versão 2.0.0.")]
        public string state { get => State; set => State = value; }
        [JsonIgnore, Obsolete("Utilize a propriedade que inicia com a letra maiúscula. Essa deixará de existir a partir da versão 2.0.0.")]
        public string country { get => Country; set => Country = value; }
    }
    public partial class Billingaddress
    {
        [JsonProperty("city", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string City { get; set; }
        [JsonProperty("district", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string District { get; set; }
        [JsonProperty("street", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Street { get; set; }
        [JsonProperty("streetNumber", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string StreetNumber { get; set; }
        [JsonProperty("zipCode", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string ZipCode { get; set; }
        [JsonProperty("state", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string State { get; set; }
        [JsonProperty("country", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Country { get; set; }
    }
}
