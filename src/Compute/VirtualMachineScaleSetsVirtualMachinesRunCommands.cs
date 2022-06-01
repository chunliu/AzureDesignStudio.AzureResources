// Licensed under the MIT License.  See LICENSE in the project root for license information.

using System;
using System.CodeDom.Compiler;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using AzureDesignStudio.AzureResources.Base;

namespace AzureDesignStudio.AzureResources.Compute
{
    /// <summary>
    /// Microsoft.Compute/virtualMachineScaleSets/virtualMachines/runCommands
    /// </summary>
    [GeneratedCode("ArmTypeGenerator", "0.1.8.0")]
    public partial class VirtualMachineScaleSetsVirtualMachinesRunCommands : ResourceBase
    {
        [Required]
        [JsonPropertyName("apiVersion")]
        public override string ApiVersion => "2021-07-01";

        /// <summary>
        /// Describes the properties of a Virtual Machine run command.
        /// </summary>
        [Required]
        [JsonPropertyName("properties")]
        public VirtualMachineRunCommandProperties Properties { get; set; }

        [Required]
        [JsonPropertyName("type")]
        public override string Type => "Microsoft.Compute/virtualMachineScaleSets/virtualMachines/runCommands";
    }
}