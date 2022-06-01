// Licensed under the MIT License.  See LICENSE in the project root for license information.

using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using AzureDesignStudio.AzureResources.Base;

namespace AzureDesignStudio.AzureResources.Compute
{
    /// <summary>
    /// The instance view of a virtual machine extension.
    /// </summary>
    [GeneratedCode("ArmTypeGenerator", "0.1.8.0")]
    public partial class VirtualMachineExtensionInstanceView
    {
        /// <summary>
        /// The virtual machine extension name.
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; set; }

        /// <summary>
        /// The resource status information.
        /// </summary>
        [JsonPropertyName("statuses")]
        public IList<InstanceViewStatus> Statuses { get; set; }

        /// <summary>
        /// The resource status information.
        /// </summary>
        [JsonPropertyName("substatuses")]
        public IList<InstanceViewStatus> Substatuses { get; set; }

        /// <summary>
        /// Specifies the type of the extension; an example is "CustomScriptExtension".
        /// </summary>
        [JsonPropertyName("type")]
        public string Type { get; set; }

        /// <summary>
        /// Specifies the version of the script handler.
        /// </summary>
        [JsonPropertyName("typeHandlerVersion")]
        public string TypeHandlerVersion { get; set; }
    }
}