using System;
using System.CodeDom.Compiler;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using AzureDesignStudio.AzureResources.Base;

namespace AzureDesignStudio.AzureResources.Sql
{
    /// <summary>
    /// Partner server information for the failover group.
    /// </summary>
    [GeneratedCode("Microsoft.Json.Schema.ToDotNet", "1.1.3.0")]
    public partial class PartnerInfo
    {
        /// <summary>
        /// Resource identifier of the partner server.
        /// </summary>
        [Required]
        [JsonPropertyName("id")]
        public string Id { get; set; }
    }
}