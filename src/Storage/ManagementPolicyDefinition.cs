using System;
using System.CodeDom.Compiler;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using AzureDesignStudio.AzureResources.Base;

namespace AzureDesignStudio.AzureResources.Storage
{
    /// <summary>
    /// An object that defines the Lifecycle rule. Each definition is made up with a filters set and an actions set.
    /// </summary>
    [GeneratedCode("Microsoft.Json.Schema.ToDotNet", "1.1.3.0")]
    public partial class ManagementPolicyDefinition
    {
        /// <summary>
        /// Actions are applied to the filtered blobs when the execution condition is met.
        /// </summary>
        [Required]
        [JsonPropertyName("actions")]
        public ManagementPolicyAction Actions { get; set; }

        /// <summary>
        /// Filters limit rule actions to a subset of blobs within the storage account. If multiple filters are defined, a logical AND is performed on all filters. 
        /// </summary>
        [JsonPropertyName("filters")]
        public ManagementPolicyFilter Filters { get; set; }
    }
}