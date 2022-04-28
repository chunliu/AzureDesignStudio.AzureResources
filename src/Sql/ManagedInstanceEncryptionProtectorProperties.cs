using System;
using System.CodeDom.Compiler;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using AzureDesignStudio.AzureResources.Base;

namespace AzureDesignStudio.AzureResources.Sql
{
    /// <summary>
    /// Properties for an encryption protector execution.
    /// </summary>
    [GeneratedCode("Microsoft.Json.Schema.ToDotNet", "1.1.3.0")]
    public partial class ManagedInstanceEncryptionProtectorProperties
    {
        /// <summary>
        /// Key auto rotation opt-in flag. Either true or false.
        /// </summary>
        [JsonPropertyName("autoRotationEnabled")]
        public bool AutoRotationEnabled { get; set; }

        /// <summary>
        /// The name of the managed instance key.
        /// </summary>
        [JsonPropertyName("serverKeyName")]
        public string ServerKeyName { get; set; }

        /// <summary>
        /// The encryption protector type like 'ServiceManaged', 'AzureKeyVault'.
        /// </summary>
        [Required]
        [JsonPropertyName("serverKeyType")]
        public string ServerKeyType { get; set; }
    }
}