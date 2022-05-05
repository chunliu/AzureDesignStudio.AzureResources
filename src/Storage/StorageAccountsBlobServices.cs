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
    /// Microsoft.Storage/storageAccounts/blobServices
    /// </summary>
    [GeneratedCode("ArmTypeGenerator", "0.1.8.0")]
    public partial class StorageAccountsBlobServices : ResourceBase
    {
        [Required]
        [JsonPropertyName("apiVersion")]
        public override string ApiVersion => "2021-06-01";

        /// <summary>
        /// The properties of a storage account’s Blob service.
        /// </summary>
        [JsonPropertyName("properties")]
        public BlobServicePropertiesProperties Properties { get; set; }
        [JsonPropertyName("resources")]
        public IList<StorageAccountsBlobServicesContainers> Resources { get; set; }

        [Required]
        [JsonPropertyName("type")]
        public override string Type => "Microsoft.Storage/storageAccounts/blobServices";
    }
}