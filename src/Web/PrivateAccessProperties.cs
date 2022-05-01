using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using AzureDesignStudio.AzureResources.Base;

namespace AzureDesignStudio.AzureResources.Web
{
    /// <summary>
    /// PrivateAccess resource specific properties
    /// </summary>
    [GeneratedCode("Microsoft.Json.Schema.ToDotNet", "1.1.3.0")]
    public partial class PrivateAccessProperties
    {
        /// <summary>
        /// Whether private access is enabled or not.
        /// </summary>
        [JsonPropertyName("enabled")]
        public bool Enabled { get; set; }

        /// <summary>
        /// The Virtual Networks (and subnets) allowed to access the site privately.
        /// </summary>
        [JsonPropertyName("virtualNetworks")]
        public IList<PrivateAccessVirtualNetwork> VirtualNetworks { get; set; }
    }
}