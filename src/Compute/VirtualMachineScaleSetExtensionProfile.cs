// Licensed under the MIT License.  See LICENSE in the project root for license information.

using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using AzureDesignStudio.AzureResources.Base;

namespace AzureDesignStudio.AzureResources.Compute
{
    /// <summary>
    /// Describes a virtual machine scale set extension profile.
    /// </summary>
    [GeneratedCode("ArmTypeGenerator", "0.1.8.0")]
    public partial class VirtualMachineScaleSetExtensionProfile
    {
        /// <summary>
        /// The virtual machine scale set child extension resources.
        /// </summary>
        [JsonPropertyName("extensions")]
        public IList<VirtualMachineScaleSetExtension> Extensions { get; set; }

        /// <summary>
        /// Specifies the time alloted for all extensions to start. The time duration should be between 15 minutes and 120 minutes (inclusive) and should be specified in ISO 8601 format. The default value is 90 minutes (PT1H30M). <br><br> Minimum api-version: 2020-06-01
        /// </summary>
        [JsonPropertyName("extensionsTimeBudget")]
        public string ExtensionsTimeBudget { get; set; }
    }
}