// Licensed under the MIT License.  See LICENSE in the project root for license information.

using System;
using System.CodeDom.Compiler;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using AzureDesignStudio.AzureResources.Base;

namespace AzureDesignStudio.AzureResources.Sql
{
    /// <summary>
    /// Contains the database information after successful export.
    /// </summary>
    [GeneratedCode("ArmTypeGenerator", "0.1.8.0")]
    public partial class DatabaseExtensionsProperties
    {
        /// <summary>
        /// Operation Mode.
        /// </summary>
        [Required]
        [JsonPropertyName("operationMode")]
        public string OperationMode { get; set; }

        /// <summary>
        /// Storage key.
        /// </summary>
        [Required]
        [JsonPropertyName("storageKey")]
        public string StorageKey { get; set; }

        /// <summary>
        /// Storage key type.
        /// </summary>
        [Required]
        [JsonPropertyName("storageKeyType")]
        public string StorageKeyType { get; set; }

        /// <summary>
        /// Storage Uri.
        /// </summary>
        [Required]
        [JsonPropertyName("storageUri")]
        public string StorageUri { get; set; }
    }
}