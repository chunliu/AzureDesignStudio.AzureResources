// Licensed under the MIT License.  See LICENSE in the project root for license information.

using System;
using System.CodeDom.Compiler;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using AzureDesignStudio.AzureResources.Base;

namespace AzureDesignStudio.AzureResources.Compute
{
    /// <summary>
    /// Describes a virtual machines IP Configuration's PublicIPAddress configuration
    /// </summary>
    [GeneratedCode("ArmTypeGenerator", "0.1.8.0")]
    public partial class VirtualMachinePublicIPAddressConfiguration
    {
        /// <summary>
        /// The publicIP address configuration name.
        /// </summary>
        [Required]
        [JsonPropertyName("name")]
        public string Name { get; set; }

        /// <summary>
        /// Describes a virtual machines IP Configuration's PublicIPAddress configuration
        /// </summary>
        [JsonPropertyName("properties")]
        public VirtualMachinePublicIPAddressConfigurationProperties Properties { get; set; }

        /// <summary>
        /// Describes the public IP Sku. It can only be set with OrchestrationMode as Flexible.
        /// </summary>
        [JsonPropertyName("sku")]
        public PublicIPAddressSku Sku { get; set; }
    }
}