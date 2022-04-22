using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using AzureDesignStudio.AzureResources.Base;

namespace AzureDesignStudio.AzureResources.Network
{
    /// <summary>
    /// Properties of the private endpoint.
    /// </summary>
    [GeneratedCode("Microsoft.Json.Schema.ToDotNet", "1.1.3.0")]
    public partial class PrivateEndpointProperties
    {
        /// <summary>
        /// The ID of the subnet from which the private IP will be allocated.
        /// </summary>
        [JsonPropertyName("subnet")]
        public SubResource Subnet { get; set; }

        /// <summary>
        /// A grouping of information about the connection to the remote resource.
        /// </summary>
        [JsonPropertyName("privateLinkServiceConnections")]
        public IList<PrivateLinkServiceConnection> PrivateLinkServiceConnections { get; set; }

        /// <summary>
        /// A grouping of information about the connection to the remote resource. Used when the network admin does not have access to approve connections to the remote resource.
        /// </summary>
        [JsonPropertyName("manualPrivateLinkServiceConnections")]
        public IList<PrivateLinkServiceConnection> ManualPrivateLinkServiceConnections { get; set; }

        /// <summary>
        /// An array of custom dns configurations.
        /// </summary>
        [JsonPropertyName("customDnsConfigs")]
        public IList<CustomDnsConfigPropertiesFormat> CustomDnsConfigs { get; set; }
    }
}