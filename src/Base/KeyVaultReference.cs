using System;
using System.CodeDom.Compiler;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace AzureDesignStudio.AzureResources.Base
{
    [GeneratedCode("Microsoft.Json.Schema.ToDotNet", "1.1.3.0")]
    public partial class KeyVaultReference
    {
        [Required]
        [JsonPropertyName("keyVault")]
        public object KeyVault { get; set; }
        [Required]
        [JsonPropertyName("secretName")]
        public string SecretName { get; set; }
        [JsonPropertyName("secretVersion")]
        public string SecretVersion { get; set; }
    }
}