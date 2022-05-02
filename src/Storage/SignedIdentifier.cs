using System;
using System.CodeDom.Compiler;
using System.Text.Json.Serialization;
using AzureDesignStudio.AzureResources.Base;

namespace AzureDesignStudio.AzureResources.Storage
{
    [GeneratedCode("Microsoft.Json.Schema.ToDotNet", "1.1.3.0")]
    public partial class SignedIdentifier
    {
        [JsonPropertyName("accessPolicy")]
        public AccessPolicy AccessPolicy { get; set; }

        /// <summary>
        /// An unique identifier of the stored access policy.
        /// </summary>
        [JsonPropertyName("id")]
        public string Id { get; set; }
    }
}