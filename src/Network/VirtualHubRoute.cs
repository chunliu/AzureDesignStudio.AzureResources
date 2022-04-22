using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using AzureDesignStudio.AzureResources.Base;

namespace AzureDesignStudio.AzureResources.Network
{
    /// <summary>
    /// VirtualHub route.
    /// </summary>
    [GeneratedCode("Microsoft.Json.Schema.ToDotNet", "1.1.3.0")]
    public partial class VirtualHubRoute
    {
        /// <summary>
        /// List of all addressPrefixes.
        /// </summary>
        [JsonPropertyName("addressPrefixes")]
        public IList<string> AddressPrefixes { get; set; }

        /// <summary>
        /// NextHop ip address.
        /// </summary>
        [JsonPropertyName("nextHopIpAddress")]
        public string NextHopIpAddress { get; set; }
    }
}