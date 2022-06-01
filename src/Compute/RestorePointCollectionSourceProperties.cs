// Licensed under the MIT License.  See LICENSE in the project root for license information.

using System;
using System.CodeDom.Compiler;
using System.Text.Json.Serialization;
using AzureDesignStudio.AzureResources.Base;

namespace AzureDesignStudio.AzureResources.Compute
{
    /// <summary>
    /// The properties of the source resource that this restore point collection is created from.
    /// </summary>
    [GeneratedCode("ArmTypeGenerator", "0.1.8.0")]
    public partial class RestorePointCollectionSourceProperties
    {
        /// <summary>
        /// Resource Id of the source resource used to create this restore point collection
        /// </summary>
        [JsonPropertyName("id")]
        public string Id { get; set; }
    }
}