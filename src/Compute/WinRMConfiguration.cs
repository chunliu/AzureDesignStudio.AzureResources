// Licensed under the MIT License.  See LICENSE in the project root for license information.

using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using AzureDesignStudio.AzureResources.Base;

namespace AzureDesignStudio.AzureResources.Compute
{
    /// <summary>
    /// Describes Windows Remote Management configuration of the VM
    /// </summary>
    [GeneratedCode("ArmTypeGenerator", "0.1.8.0")]
    public partial class WinRMConfiguration
    {
        /// <summary>
        /// The list of Windows Remote Management listeners
        /// </summary>
        [JsonPropertyName("listeners")]
        public IList<WinRMListener> Listeners { get; set; }
    }
}