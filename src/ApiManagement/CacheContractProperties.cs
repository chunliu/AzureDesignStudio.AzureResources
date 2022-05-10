// Licensed under the MIT License.  See LICENSE in the project root for license information.

using System;
using System.CodeDom.Compiler;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using AzureDesignStudio.AzureResources.Base;

namespace AzureDesignStudio.AzureResources.ApiManagement
{
    /// <summary>
    /// Properties of the Cache contract.
    /// </summary>
    [GeneratedCode("ArmTypeGenerator", "0.1.8.0")]
    public partial class CacheContractProperties
    {
        /// <summary>
        /// Runtime connection string to cache
        /// </summary>
        [Required]
        [JsonPropertyName("connectionString")]
        public string ConnectionString { get; set; }

        /// <summary>
        /// Cache description
        /// </summary>
        [JsonPropertyName("description")]
        public string Description { get; set; }

        /// <summary>
        /// Original uri of entity in external system cache points to
        /// </summary>
        [JsonPropertyName("resourceId")]
        public string ResourceId { get; set; }

        /// <summary>
        /// Location identifier to use cache from (should be either 'default' or valid Azure region identifier)
        /// </summary>
        [Required]
        [JsonPropertyName("useFromLocation")]
        public string UseFromLocation { get; set; }
    }
}