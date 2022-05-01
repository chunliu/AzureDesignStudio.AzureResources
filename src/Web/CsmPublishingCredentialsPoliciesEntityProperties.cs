using System;
using System.CodeDom.Compiler;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using AzureDesignStudio.AzureResources.Base;

namespace AzureDesignStudio.AzureResources.Web
{
    /// <summary>
    /// CsmPublishingCredentialsPoliciesEntity resource specific properties
    /// </summary>
    [GeneratedCode("Microsoft.Json.Schema.ToDotNet", "1.1.3.0")]
    public partial class CsmPublishingCredentialsPoliciesEntityProperties
    {
        /// <summary>
        /// <code>true</code> to allow access to a publishing method; otherwise, <code>false</code>.
        /// </summary>
        [Required]
        [JsonPropertyName("allow")]
        public bool Allow { get; set; }
    }
}