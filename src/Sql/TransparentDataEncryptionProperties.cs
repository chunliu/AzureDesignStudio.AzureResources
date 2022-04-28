using System;
using System.CodeDom.Compiler;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using AzureDesignStudio.AzureResources.Base;

namespace AzureDesignStudio.AzureResources.Sql
{
    /// <summary>
    /// Properties of a transparent data encryption.
    /// </summary>
    [GeneratedCode("Microsoft.Json.Schema.ToDotNet", "1.1.3.0")]
    public partial class TransparentDataEncryptionProperties
    {
        /// <summary>
        /// Specifies the state of the transparent data encryption.
        /// </summary>
        [Required]
        [JsonPropertyName("state")]
        public string State { get; set; }
    }
}