// Licensed under the MIT License.  See LICENSE in the project root for license information.

using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using AzureDesignStudio.AzureResources.Base;

namespace AzureDesignStudio.AzureResources.Compute
{
    /// <summary>
    /// Specifies the user intent of the proximity placement group.
    /// </summary>
    [GeneratedCode("ArmTypeGenerator", "0.1.8.0")]
    public partial class ProximityPlacementGroupPropertiesIntent
    {
        /// <summary>
        /// Specifies possible sizes of virtual machines that can be created in the proximity placement group.
        /// </summary>
        [JsonPropertyName("vmSizes")]
        public IList<string> VmSizes { get; set; }
    }
}