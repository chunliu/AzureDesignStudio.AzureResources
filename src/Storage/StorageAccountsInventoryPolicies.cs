// Licensed under the MIT License.  See LICENSE in the project root for license information.

using System;
using System.CodeDom.Compiler;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using AzureDesignStudio.AzureResources.Base;

namespace AzureDesignStudio.AzureResources.Storage
{
    /// <summary>
    /// Microsoft.Storage/storageAccounts/inventoryPolicies
    /// </summary>
    [GeneratedCode("ArmTypeGenerator", "0.1.8.0")]
    public partial class StorageAccountsInventoryPolicies : ResourceBase
    {
        [Required]
        [JsonPropertyName("apiVersion")]
        public override string ApiVersion => "2021-06-01";

        /// <summary>
        /// The storage account blob inventory policy properties.
        /// </summary>
        [JsonPropertyName("properties")]
        public BlobInventoryPolicyProperties Properties { get; set; }

        /// <summary>
        /// Metadata pertaining to creation and last modification of the resource.
        /// </summary>
        [JsonPropertyName("systemData")]
        public SystemData SystemData { get; set; }

        [Required]
        [JsonPropertyName("type")]
        public override string Type => "Microsoft.Storage/storageAccounts/inventoryPolicies";
    }
}