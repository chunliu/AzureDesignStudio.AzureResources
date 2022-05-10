// Licensed under the MIT License.  See LICENSE in the project root for license information.

using System;
using System.CodeDom.Compiler;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using AzureDesignStudio.AzureResources.Base;

namespace AzureDesignStudio.AzureResources.ApiManagement
{
    /// <summary>
    /// API Management service resource SKU properties.
    /// </summary>
    [GeneratedCode("ArmTypeGenerator", "0.1.8.0")]
    public partial class ApiManagementServiceSkuProperties
    {
        /// <summary>
        /// Capacity of the SKU (number of deployed units of the SKU). For Consumption SKU capacity must be specified as 0.
        /// </summary>
        [Required]
        [JsonPropertyName("capacity")]
        public int Capacity { get; set; }

        /// <summary>
        /// Name of the Sku.
        /// </summary>
        [Required]
        [JsonPropertyName("name")]
        public string Name { get; set; }
    }
}