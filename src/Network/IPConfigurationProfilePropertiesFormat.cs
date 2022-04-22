using System;
using System.CodeDom.Compiler;
using System.Text.Json.Serialization;
using AzureDesignStudio.AzureResources.Base;

namespace AzureDesignStudio.AzureResources.Network
{
    /// <summary>
    /// IP configuration profile properties.
    /// </summary>
    [GeneratedCode("Microsoft.Json.Schema.ToDotNet", "1.1.3.0")]
    public partial class IPConfigurationProfilePropertiesFormat
    {
        /// <summary>
        /// The reference to the subnet resource to create a container network interface ip configuration.
        /// </summary>
        [JsonPropertyName("subnet")]
        public SubResource Subnet { get; set; }
    }
}