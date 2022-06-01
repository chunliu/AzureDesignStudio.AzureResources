// Licensed under the MIT License.  See LICENSE in the project root for license information.

using System;
using System.CodeDom.Compiler;
using System.Text.Json.Serialization;
using AzureDesignStudio.AzureResources.Base;

namespace AzureDesignStudio.AzureResources.Compute
{
    /// <summary>
    /// The restore point collection properties.
    /// </summary>
    [GeneratedCode("ArmTypeGenerator", "0.1.8.0")]
    public partial class RestorePointCollectionProperties
    {
        /// <summary>
        /// The properties of the source resource that this restore point collection is created from.
        /// </summary>
        [JsonPropertyName("source")]
        public RestorePointCollectionSourceProperties Source { get; set; }
    }
}