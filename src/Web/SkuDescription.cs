// Licensed under the MIT License.  See LICENSE in the project root for license information.

using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using AzureDesignStudio.AzureResources.Base;

namespace AzureDesignStudio.AzureResources.Web
{
    /// <summary>
    /// Description of a SKU for a scalable resource.
    /// </summary>
    [GeneratedCode("ArmTypeGenerator", "0.1.8.0")]
    public partial class SkuDescription
    {
        /// <summary>
        /// Capabilities of the SKU, e.g., is traffic manager enabled?
        /// </summary>
        [JsonPropertyName("capabilities")]
        public IList<Capability> Capabilities { get; set; }

        /// <summary>
        /// Current number of instances assigned to the resource.
        /// </summary>
        [JsonPropertyName("capacity")]
        public int Capacity { get; set; }

        /// <summary>
        /// Family code of the resource SKU.
        /// </summary>
        [JsonPropertyName("family")]
        public string Family { get; set; }

        /// <summary>
        /// Locations of the SKU.
        /// </summary>
        [JsonPropertyName("locations")]
        public IList<string> Locations { get; set; }

        /// <summary>
        /// Name of the resource SKU.
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; set; }

        /// <summary>
        /// Size specifier of the resource SKU.
        /// </summary>
        [JsonPropertyName("size")]
        public string Size { get; set; }

        /// <summary>
        /// Description of the App Service plan scale options.
        /// </summary>
        [JsonPropertyName("skuCapacity")]
        public SkuCapacity SkuCapacity { get; set; }

        /// <summary>
        /// Service tier of the resource SKU.
        /// </summary>
        [JsonPropertyName("tier")]
        public string Tier { get; set; }
    }
}