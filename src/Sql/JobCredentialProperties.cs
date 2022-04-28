using System;
using System.CodeDom.Compiler;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using AzureDesignStudio.AzureResources.Base;

namespace AzureDesignStudio.AzureResources.Sql
{
    /// <summary>
    /// Properties of a job credential.
    /// </summary>
    [GeneratedCode("Microsoft.Json.Schema.ToDotNet", "1.1.3.0")]
    public partial class JobCredentialProperties
    {
        /// <summary>
        /// The credential password.
        /// </summary>
        [Required]
        [JsonPropertyName("password")]
        public string Password { get; set; }

        /// <summary>
        /// The credential user name.
        /// </summary>
        [Required]
        [JsonPropertyName("username")]
        public string Username { get; set; }
    }
}