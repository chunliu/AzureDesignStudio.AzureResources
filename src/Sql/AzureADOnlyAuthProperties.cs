using System;
using System.CodeDom.Compiler;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using AzureDesignStudio.AzureResources.Base;

namespace AzureDesignStudio.AzureResources.Sql
{
    /// <summary>
    /// Properties of a active directory only authentication.
    /// </summary>
    [GeneratedCode("Microsoft.Json.Schema.ToDotNet", "1.1.3.0")]
    public partial class AzureADOnlyAuthProperties
    {
        /// <summary>
        /// Azure Active Directory only Authentication enabled.
        /// </summary>
        [Required]
        [JsonPropertyName("azureADOnlyAuthentication")]
        public bool AzureADOnlyAuthentication { get; set; }
    }
}