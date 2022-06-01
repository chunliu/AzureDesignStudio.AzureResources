// Licensed under the MIT License.  See LICENSE in the project root for license information.

using System;
using System.CodeDom.Compiler;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using AzureDesignStudio.AzureResources.Base;

namespace AzureDesignStudio.AzureResources.Compute
{
    /// <summary>
    /// Microsoft.Compute/virtualMachineScaleSets/extensions
    /// </summary>
    [GeneratedCode("ArmTypeGenerator", "0.1.8.0")]
    public partial class VirtualMachineScaleSetsExtensions
    {
        [Required]
        [JsonPropertyName("apiVersion")]
        public string ApiVersion { get; set; }

        /// <summary>
        /// The name of the VM scale set extension.
        /// </summary>
        [Required]
        [JsonPropertyName("name")]
        public string Name { get; set; }

        /// <summary>
        /// Describes the properties of a Virtual Machine Scale Set Extension.
        /// </summary>
        [Required]
        [JsonPropertyName("properties")]
        public VirtualMachineScaleSetExtensionProperties Properties { get; set; }
        [Required]
        [JsonPropertyName("type")]
        public string Type { get; set; }
    }
}