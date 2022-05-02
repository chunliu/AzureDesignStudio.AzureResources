using System;
using System.CodeDom.Compiler;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using AzureDesignStudio.AzureResources.Base;

namespace AzureDesignStudio.AzureResources.Storage
{
    /// <summary>
    /// An object that wraps the Lifecycle rule. Each rule is uniquely defined by name.
    /// </summary>
    [GeneratedCode("Microsoft.Json.Schema.ToDotNet", "1.1.3.0")]
    public partial class ManagementPolicyRule
    {
        /// <summary>
        /// An object that defines the Lifecycle rule. Each definition is made up with a filters set and an actions set.
        /// </summary>
        [Required]
        [JsonPropertyName("definition")]
        public ManagementPolicyDefinition Definition { get; set; }

        /// <summary>
        /// Rule is enabled if set to true.
        /// </summary>
        [JsonPropertyName("enabled")]
        public bool Enabled { get; set; }

        /// <summary>
        /// A rule name can contain any combination of alpha numeric characters. Rule name is case-sensitive. It must be unique within a policy.
        /// </summary>
        [Required]
        [JsonPropertyName("name")]
        public string Name { get; set; }

        /// <summary>
        /// The valid value is Lifecycle
        /// </summary>
        [Required]
        [JsonPropertyName("type")]
        public string Type { get; set; }
    }
}