using System;
using System.CodeDom.Compiler;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using AzureDesignStudio.AzureResources.Base;

namespace AzureDesignStudio.AzureResources.Network
{
    /// <summary>
    /// Properties of IP configuration of an Bastion Host.
    /// </summary>
    [GeneratedCode("Microsoft.Json.Schema.ToDotNet", "1.1.3.0")]
    public partial class BastionHostIPConfigurationPropertiesFormat
    {
        /// <summary>
        /// Reference of the subnet resource.
        /// </summary>
        [Required]
        [JsonPropertyName("subnet")]
        public SubResource Subnet { get; set; }

        /// <summary>
        /// Reference of the PublicIP resource.
        /// </summary>
        [Required]
        [JsonPropertyName("publicIPAddress")]
        public SubResource PublicIPAddress { get; set; }

        /// <summary>
        /// Private IP allocation method.
        /// </summary>
        [JsonPropertyName("privateIPAllocationMethod")]
        public string PrivateIPAllocationMethod { get; set; }
    }
}