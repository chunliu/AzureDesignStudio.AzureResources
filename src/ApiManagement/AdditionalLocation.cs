// Licensed under the MIT License.  See LICENSE in the project root for license information.

using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using AzureDesignStudio.AzureResources.Base;

namespace AzureDesignStudio.AzureResources.ApiManagement
{
    /// <summary>
    /// Description of an additional API Management resource location.
    /// </summary>
    [GeneratedCode("ArmTypeGenerator", "0.1.8.0")]
    public partial class AdditionalLocation
    {
        /// <summary>
        /// Property only valid for an Api Management service deployed in multiple locations. This can be used to disable the gateway in this additional location.
        /// </summary>
        [JsonPropertyName("disableGateway")]
        public bool DisableGateway { get; set; }

        /// <summary>
        /// The location name of the additional region among Azure Data center regions.
        /// </summary>
        [Required]
        [JsonPropertyName("location")]
        public string Location { get; set; }

        /// <summary>
        /// Public Standard SKU IP V4 based IP address to be associated with Virtual Network deployed service in the location. Supported only for Premium SKU being deployed in Virtual Network.
        /// </summary>
        [JsonPropertyName("publicIpAddressId")]
        public string PublicIpAddressId { get; set; }

        /// <summary>
        /// API Management service resource SKU properties.
        /// </summary>
        [Required]
        [JsonPropertyName("sku")]
        public ApiManagementServiceSkuProperties Sku { get; set; }

        /// <summary>
        /// Configuration of a virtual network to which API Management service is deployed.
        /// </summary>
        [JsonPropertyName("virtualNetworkConfiguration")]
        public VirtualNetworkConfiguration VirtualNetworkConfiguration { get; set; }

        /// <summary>
        /// A list of availability zones denoting where the resource needs to come from.
        /// </summary>
        [JsonPropertyName("zones")]
        public IList<string> Zones { get; set; }
    }
}