using System;
using System.CodeDom.Compiler;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using AzureDesignStudio.AzureResources.Base;

namespace AzureDesignStudio.AzureResources.Storage
{
    /// <summary>
    /// IP rule with specific IP or IP range in CIDR format.
    /// </summary>
    [GeneratedCode("Microsoft.Json.Schema.ToDotNet", "1.1.3.0")]
    public partial class IPRule
    {
        /// <summary>
        /// The action of IP ACL rule.
        /// </summary>
        [JsonPropertyName("action")]
        public string Action { get; set; }

        /// <summary>
        /// Specifies the IP or IP range in CIDR format. Only IPV4 address is allowed.
        /// </summary>
        [Required]
        [JsonPropertyName("value")]
        public string Value { get; set; }
    }
}