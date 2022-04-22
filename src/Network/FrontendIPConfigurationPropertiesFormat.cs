using System;
using System.CodeDom.Compiler;
using System.Text.Json.Serialization;
using AzureDesignStudio.AzureResources.Base;

namespace AzureDesignStudio.AzureResources.Network
{
    /// <summary>
    /// Properties of Frontend IP Configuration of the load balancer.
    /// </summary>
    [GeneratedCode("Microsoft.Json.Schema.ToDotNet", "1.1.3.0")]
    public partial class FrontendIPConfigurationPropertiesFormat
    {
        /// <summary>
        /// The private IP address of the IP configuration.
        /// </summary>
        [JsonPropertyName("privateIPAddress")]
        public string PrivateIPAddress { get; set; }

        /// <summary>
        /// The Private IP allocation method.
        /// </summary>
        [JsonPropertyName("privateIPAllocationMethod")]
        public string PrivateIPAllocationMethod { get; set; }

        /// <summary>
        /// Whether the specific ipconfiguration is IPv4 or IPv6. Default is taken as IPv4.
        /// </summary>
        [JsonPropertyName("privateIPAddressVersion")]
        public string PrivateIPAddressVersion { get; set; }

        /// <summary>
        /// The reference to the subnet resource.
        /// </summary>
        [JsonPropertyName("subnet")]
        public SubResource Subnet { get; set; }

        /// <summary>
        /// The reference to the Public IP resource.
        /// </summary>
        [JsonPropertyName("publicIPAddress")]
        public SubResource PublicIPAddress { get; set; }

        /// <summary>
        /// The reference to the Public IP Prefix resource.
        /// </summary>
        [JsonPropertyName("publicIPPrefix")]
        public SubResource PublicIPPrefix { get; set; }
    }
}