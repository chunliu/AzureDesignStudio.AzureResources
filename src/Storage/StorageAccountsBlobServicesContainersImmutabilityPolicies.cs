// Licensed under the MIT License.  See LICENSE in the project root for license information.

using System;
using System.CodeDom.Compiler;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using AzureDesignStudio.AzureResources.Base;

namespace AzureDesignStudio.AzureResources.Storage
{
    /// <summary>
    /// Microsoft.Storage/storageAccounts/blobServices/containers/immutabilityPolicies
    /// </summary>
    [GeneratedCode("ArmTypeGenerator", "0.1.8.0")]
    public partial class StorageAccountsBlobServicesContainersImmutabilityPolicies : ResourceBase
    {
        [Required]
        [JsonPropertyName("apiVersion")]
        public override string ApiVersion => "2021-06-01";

        /// <summary>
        /// The properties of an ImmutabilityPolicy of a blob container.
        /// </summary>
        [JsonPropertyName("properties")]
        public ImmutabilityPolicyProperty Properties { get; set; }

        [Required]
        [JsonPropertyName("type")]
        public override string Type => "Microsoft.Storage/storageAccounts/blobServices/containers/immutabilityPolicies";
    }
}