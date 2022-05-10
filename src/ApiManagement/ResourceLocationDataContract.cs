// Licensed under the MIT License.  See LICENSE in the project root for license information.

using System;
using System.CodeDom.Compiler;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using AzureDesignStudio.AzureResources.Base;

namespace AzureDesignStudio.AzureResources.ApiManagement
{
    /// <summary>
    /// Resource location data properties.
    /// </summary>
    [GeneratedCode("ArmTypeGenerator", "0.1.8.0")]
    public partial class ResourceLocationDataContract
    {
        /// <summary>
        /// The city or locality where the resource is located.
        /// </summary>
        [JsonPropertyName("city")]
        public string City { get; set; }

        /// <summary>
        /// The country or region where the resource is located.
        /// </summary>
        [JsonPropertyName("countryOrRegion")]
        public string CountryOrRegion { get; set; }

        /// <summary>
        /// The district, state, or province where the resource is located.
        /// </summary>
        [JsonPropertyName("district")]
        public string District { get; set; }

        /// <summary>
        /// A canonical name for the geographic or physical location.
        /// </summary>
        [Required]
        [JsonPropertyName("name")]
        public string Name { get; set; }
    }
}