// Licensed under the MIT License.  See LICENSE in the project root for license information.

using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using AzureDesignStudio.AzureResources.Base;

namespace AzureDesignStudio.AzureResources.Compute
{
    /// <summary>
    /// Microsoft.Compute/virtualMachines/extensions
    /// </summary>
    [GeneratedCode("ArmTypeGenerator", "0.1.8.0")]
    public partial class VirtualMachinesExtensions
    {
        [Required]
        [JsonPropertyName("apiVersion")]
        public string ApiVersion { get; set; }

        /// <summary>
        /// Resource location
        /// </summary>
        [Required]
        [JsonPropertyName("location")]
        public string Location { get; set; }

        /// <summary>
        /// The name of the virtual machine extension.
        /// </summary>
        [Required]
        [JsonPropertyName("name")]
        public string Name { get; set; }
        [Required]
        [JsonPropertyName("properties")]
        public object Properties { get; set; }

        /// <summary>
        /// Resource tags
        /// </summary>
        [JsonPropertyName("tags")]
        public IDictionary<string, string> Tags { get; set; }
        [Required]
        [JsonPropertyName("type")]
        public string Type { get; set; }
    }
}