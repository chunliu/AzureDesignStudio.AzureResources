using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using AzureDesignStudio.AzureResources.Base;

namespace AzureDesignStudio.AzureResources.Sql
{
    /// <summary>
    /// Microsoft.Sql/servers/jobAgents
    /// </summary>
    [GeneratedCode("Microsoft.Json.Schema.ToDotNet", "1.1.3.0")]
    public partial class ServersJobAgents : ResourceBase
    {
        [Required]
        [JsonPropertyName("apiVersion")]
        public override string ApiVersion => "2021-02-01-preview";

        /// <summary>
        /// Properties of a job agent.
        /// </summary>
        [Required]
        [JsonPropertyName("properties")]
        public JobAgentProperties Properties { get; set; }
        [JsonPropertyName("resources")]
        public IList<ServersJobAgentsCredentials> Resources { get; set; }

        /// <summary>
        /// An ARM Resource SKU.
        /// </summary>
        [JsonPropertyName("sku")]
        public Sku Sku { get; set; }

        [Required]
        [JsonPropertyName("type")]
        public override string Type => "Microsoft.Sql/servers/jobAgents";
    }
}