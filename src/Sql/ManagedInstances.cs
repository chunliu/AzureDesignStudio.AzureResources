using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using AzureDesignStudio.AzureResources.Base;

namespace AzureDesignStudio.AzureResources.Sql
{
    /// <summary>
    /// Microsoft.Sql/managedInstances
    /// </summary>
    [GeneratedCode("Microsoft.Json.Schema.ToDotNet", "1.1.3.0")]
    public partial class ManagedInstances : ResourceBase
    {
        [Required]
        [JsonPropertyName("apiVersion")]
        public override string ApiVersion => "2021-02-01-preview";

        /// <summary>
        /// Azure Active Directory identity configuration for a resource.
        /// </summary>
        [JsonPropertyName("identity")]
        public ResourceIdentity Identity { get; set; }

        /// <summary>
        /// The properties of a managed instance.
        /// </summary>
        [Required]
        [JsonPropertyName("properties")]
        public ManagedInstanceProperties Properties { get; set; }
        [JsonPropertyName("resources")]
        public IList<ManagedInstances_databases> Resources { get; set; }

        /// <summary>
        /// An ARM Resource SKU.
        /// </summary>
        [JsonPropertyName("sku")]
        public Sku Sku { get; set; }

        [Required]
        [JsonPropertyName("type")]
        public override string Type => "Microsoft.Sql/managedInstances";
    }
}