using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using AzureDesignStudio.AzureResources.Base;

namespace AzureDesignStudio.AzureResources.Network
{
    /// <summary>
    /// Virtual Router definition.
    /// </summary>
    [GeneratedCode("Microsoft.Json.Schema.ToDotNet", "1.1.3.0")]
    public partial class VirtualRouterPropertiesFormat
    {
        /// <summary>
        /// VirtualRouter ASN.
        /// </summary>
        [JsonPropertyName("virtualRouterAsn")]
        public int VirtualRouterAsn { get; set; }

        /// <summary>
        /// VirtualRouter IPs.
        /// </summary>
        [JsonPropertyName("virtualRouterIps")]
        public IList<string> VirtualRouterIps { get; set; }

        /// <summary>
        /// The Subnet on which VirtualRouter is hosted.
        /// </summary>
        [JsonPropertyName("hostedSubnet")]
        public SubResource HostedSubnet { get; set; }

        /// <summary>
        /// The Gateway on which VirtualRouter is hosted.
        /// </summary>
        [JsonPropertyName("hostedGateway")]
        public SubResource HostedGateway { get; set; }
    }
}