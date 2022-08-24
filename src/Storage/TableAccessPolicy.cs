// Licensed under the MIT License.  See LICENSE in the project root for license information.

using System;
using System.CodeDom.Compiler;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using AzureDesignStudio.AzureResources.Base;

namespace AzureDesignStudio.AzureResources.Storage
{
    /// <summary>
    /// Table Access Policy Properties Object.
    /// </summary>
    [GeneratedCode("ArmTypeGenerator", "0.1.8.0")]
    public partial class TableAccessPolicy
    {
        /// <summary>
        /// Expiry time of the access policy
        /// </summary>
        [JsonPropertyName("expiryTime")]
        public DateTime ExpiryTime { get; set; }

        /// <summary>
        /// Required. List of abbreviated permissions. Supported permission values include 'r','a','u','d'
        /// </summary>
        [Required]
        [JsonPropertyName("permission")]
        public string Permission { get; set; }

        /// <summary>
        /// Start time of the access policy
        /// </summary>
        [JsonPropertyName("startTime")]
        public DateTime StartTime { get; set; }
    }
}