using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using AzureDesignStudio.AzureResources.Base;

namespace AzureDesignStudio.AzureResources.Network
{
    /// <summary>
    /// The IpGroups property information.
    /// </summary>
    [GeneratedCode("Microsoft.Json.Schema.ToDotNet", "1.1.3.0")]
    public partial class IpGroupPropertiesFormat
    {
        /// <summary>
        /// IpAddresses/IpAddressPrefixes in the IpGroups resource.
        /// </summary>
        [JsonPropertyName("ipAddresses")]
        public IList<string> IpAddresses { get; set; }
    }
}