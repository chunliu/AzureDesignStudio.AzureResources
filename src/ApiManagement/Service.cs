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
    /// Microsoft.ApiManagement/service
    /// </summary>
    [GeneratedCode("ArmTypeGenerator", "0.1.8.0")]
    public partial class Service : ResourceBase
    {
        [Required]
        [JsonPropertyName("apiVersion")]
        public override string ApiVersion => "2021-12-01-preview";

        /// <summary>
        /// Identity properties of the Api Management service resource.
        /// </summary>
        [JsonPropertyName("identity")]
        public ApiManagementServiceIdentity Identity { get; set; }

        /// <summary>
        /// Properties of an API Management service resource description.
        /// </summary>
        [Required]
        [JsonPropertyName("properties")]
        public ApiManagementServiceProperties Properties { get; set; }
        [JsonPropertyName("resources")]
        public IList<ServiceApis> Resources { get; set; }

        /// <summary>
        /// API Management service resource SKU properties.
        /// </summary>
        [Required]
        [JsonPropertyName("sku")]
        public ApiManagementServiceSkuProperties Sku { get; set; }

        [Required]
        [JsonPropertyName("type")]
        public override string Type => "Microsoft.ApiManagement/service";

        /// <summary>
        /// A list of availability zones denoting where the resource needs to come from.
        /// </summary>
        [JsonPropertyName("zones")]
        public IList<string> Zones { get; set; }
    }
}