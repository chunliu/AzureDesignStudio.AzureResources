// Licensed under the MIT License.  See LICENSE in the project root for license information.

using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using AzureDesignStudio.AzureResources.Base;

namespace AzureDesignStudio.AzureResources.Storage
{
    /// <summary>
    /// Microsoft.Storage/storageAccounts
    /// </summary>
    [GeneratedCode("ArmTypeGenerator", "0.1.8.0")]
    public partial class StorageAccounts : ResourceBase
    {
        [Required]
        [JsonPropertyName("apiVersion")]
        public override string ApiVersion => "2021-06-01";

        /// <summary>
        /// The complex type of the extended location.
        /// </summary>
        [JsonPropertyName("extendedLocation")]
        public ExtendedLocation ExtendedLocation { get; set; }

        /// <summary>
        /// Identity for the resource.
        /// </summary>
        [JsonPropertyName("identity")]
        public Identity Identity { get; set; }

        /// <summary>
        /// Required. Indicates the type of storage account.
        /// </summary>
        [Required]
        [JsonPropertyName("kind")]
        public string Kind { get; set; }

        /// <summary>
        /// The parameters used to create the storage account.
        /// </summary>
        [JsonPropertyName("properties")]
        public StorageAccountPropertiesCreateParameters Properties { get; set; }
        [JsonPropertyName("resources")]
        public IList<ResourceBase> Resources { get; set; }

        /// <summary>
        /// The SKU of the storage account.
        /// </summary>
        [Required]
        [JsonPropertyName("sku")]
        public Sku Sku { get; set; }

        [Required]
        [JsonPropertyName("type")]
        public override string Type => "Microsoft.Storage/storageAccounts";
    }
}