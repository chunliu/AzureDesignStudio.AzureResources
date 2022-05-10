// Licensed under the MIT License.  See LICENSE in the project root for license information.

using System;
using System.CodeDom.Compiler;
using System.Text.Json.Serialization;
using AzureDesignStudio.AzureResources.Base;

namespace AzureDesignStudio.AzureResources.ApiManagement
{
    /// <summary>
    /// Properties of the Gateway contract.
    /// </summary>
    [GeneratedCode("ArmTypeGenerator", "0.1.8.0")]
    public partial class GatewayContractProperties
    {
        /// <summary>
        /// Gateway description
        /// </summary>
        [JsonPropertyName("description")]
        public string Description { get; set; }

        /// <summary>
        /// Resource location data properties.
        /// </summary>
        [JsonPropertyName("locationData")]
        public ResourceLocationDataContract LocationData { get; set; }
    }
}