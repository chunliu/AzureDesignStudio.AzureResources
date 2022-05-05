// Licensed under the MIT License.  See LICENSE in the project root for license information.

using System;
using System.CodeDom.Compiler;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using AzureDesignStudio.AzureResources.Base;

namespace AzureDesignStudio.AzureResources.Storage
{
    /// <summary>
    /// An object that wraps the blob inventory rule. Each rule is uniquely defined by name.
    /// </summary>
    [GeneratedCode("ArmTypeGenerator", "0.1.8.0")]
    public partial class BlobInventoryPolicyRule
    {
        /// <summary>
        /// An object that defines the blob inventory rule.
        /// </summary>
        [Required]
        [JsonPropertyName("definition")]
        public BlobInventoryPolicyDefinition Definition { get; set; }

        /// <summary>
        /// Container name where blob inventory files are stored. Must be pre-created.
        /// </summary>
        [Required]
        [JsonPropertyName("destination")]
        public string Destination { get; set; }

        /// <summary>
        /// Rule is enabled when set to true.
        /// </summary>
        [Required]
        [JsonPropertyName("enabled")]
        public bool Enabled { get; set; }

        /// <summary>
        /// A rule name can contain any combination of alpha numeric characters. Rule name is case-sensitive. It must be unique within a policy.
        /// </summary>
        [Required]
        [JsonPropertyName("name")]
        public string Name { get; set; }
    }
}