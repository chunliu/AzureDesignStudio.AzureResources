using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using AzureDesignStudio.AzureResources.Base;

namespace AzureDesignStudio.AzureResources.Web
{
    /// <summary>
    /// IP security restriction on an app.
    /// </summary>
    [GeneratedCode("Microsoft.Json.Schema.ToDotNet", "1.1.3.0")]
    public partial class IpSecurityRestriction
    {
        /// <summary>
        /// Allow or Deny access for this IP range.
        /// </summary>
        [JsonPropertyName("action")]
        public string Action { get; set; }

        /// <summary>
        /// IP restriction rule description.
        /// </summary>
        [JsonPropertyName("description")]
        public string Description { get; set; }

        /// <summary>
        /// IP restriction rule headers.
        [JsonPropertyName("headers")]
        public IDictionary<string, IList<string>> Headers { get; set; }

        /// <summary>
        /// IP address the security restriction is valid for.
        [JsonPropertyName("ipAddress")]
        public string IpAddress { get; set; }

        /// <summary>
        /// IP restriction rule name.
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; set; }

        /// <summary>
        /// Priority of IP restriction rule.
        /// </summary>
        [JsonPropertyName("priority")]
        public int Priority { get; set; }

        /// <summary>
        /// Subnet mask for the range of IP addresses the restriction is valid for.
        /// </summary>
        [JsonPropertyName("subnetMask")]
        public string SubnetMask { get; set; }

        /// <summary>
        /// (internal) Subnet traffic tag
        /// </summary>
        [JsonPropertyName("subnetTrafficTag")]
        public int SubnetTrafficTag { get; set; }

        /// <summary>
        /// Defines what this IP filter will be used for. This is to support IP filtering on proxies.
        /// </summary>
        [JsonPropertyName("tag")]
        public string Tag { get; set; }

        /// <summary>
        /// Virtual network resource id
        /// </summary>
        [JsonPropertyName("vnetSubnetResourceId")]
        public string VnetSubnetResourceId { get; set; }

        /// <summary>
        /// (internal) Vnet traffic tag
        /// </summary>
        [JsonPropertyName("vnetTrafficTag")]
        public int VnetTrafficTag { get; set; }
    }
}