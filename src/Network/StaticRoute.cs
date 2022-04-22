using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using AzureDesignStudio.AzureResources.Base;

namespace AzureDesignStudio.AzureResources.Network
{
    /// <summary>
    /// List of all Static Routes.
    /// </summary>
    [GeneratedCode("Microsoft.Json.Schema.ToDotNet", "1.1.3.0")]
    public partial class StaticRoute
    {
        /// <summary>
        /// The name of the StaticRoute that is unique within a VnetRoute.
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; set; }

        /// <summary>
        /// List of all address prefixes.
        /// </summary>
        [JsonPropertyName("addressPrefixes")]
        public IList<string> AddressPrefixes { get; set; }

        /// <summary>
        /// The ip address of the next hop.
        /// </summary>
        [JsonPropertyName("nextHopIpAddress")]
        public string NextHopIpAddress { get; set; }
    }
}