using System;
using System.CodeDom.Compiler;
using System.Text.Json.Serialization;
using AzureDesignStudio.AzureResources.Base;

namespace AzureDesignStudio.AzureResources.Web
{
    /// <summary>
    /// Identifier resource specific properties
    /// </summary>
    [GeneratedCode("Microsoft.Json.Schema.ToDotNet", "1.1.3.0")]
    public partial class IdentifierProperties
    {
        /// <summary>
        /// String representation of the identity.
        /// </summary>
        [JsonPropertyName("id")]
        public string Id { get; set; }
    }
}