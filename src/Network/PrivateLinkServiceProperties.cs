using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using AzureDesignStudio.AzureResources.Base;

namespace AzureDesignStudio.AzureResources.Network
{
    /// <summary>
    /// Properties of the private link service.
    /// </summary>
    [GeneratedCode("Microsoft.Json.Schema.ToDotNet", "1.1.3.0")]
    public partial class PrivateLinkServiceProperties
    {
        /// <summary>
        /// An array of references to the load balancer IP configurations.
        /// </summary>
        [JsonPropertyName("loadBalancerFrontendIpConfigurations")]
        public IList<SubResource> LoadBalancerFrontendIpConfigurations { get; set; }

        /// <summary>
        /// An array of private link service IP configurations.
        /// </summary>
        [JsonPropertyName("ipConfigurations")]
        public IList<PrivateLinkServiceIpConfiguration> IpConfigurations { get; set; }

        /// <summary>
        /// The visibility list of the private link service.
        /// </summary>
        [JsonPropertyName("visibility")]
        public PrivateLinkServicePropertiesVisibility Visibility { get; set; }

        /// <summary>
        /// The auto-approval list of the private link service.
        /// </summary>
        [JsonPropertyName("autoApproval")]
        public PrivateLinkServicePropertiesAutoApproval AutoApproval { get; set; }

        /// <summary>
        /// The list of Fqdn.
        /// </summary>
        [JsonPropertyName("fqdns")]
        public IList<string> Fqdns { get; set; }

        /// <summary>
        /// Whether the private link service is enabled for proxy protocol or not.
        /// </summary>
        [JsonPropertyName("enableProxyProtocol")]
        public bool EnableProxyProtocol { get; set; }
    }
}