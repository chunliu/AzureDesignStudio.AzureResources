using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using AzureDesignStudio.AzureResources.Base;

namespace AzureDesignStudio.AzureResources.Sql
{
    /// <summary>
    /// Microsoft.Sql/servers
    /// </summary>
    [GeneratedCode("Microsoft.Json.Schema.ToDotNet", "1.1.3.0")]
    public partial class Servers : ResourceBase
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
        /// The properties of a server.
        /// </summary>
        [Required]
        [JsonPropertyName("properties")]
        public ServerProperties Properties { get; set; }
        [JsonPropertyName("resources")]
        public IList<Servers_databases> Resources { get; set; }

        [Required]
        [JsonPropertyName("type")]
        public override string Type => "Microsoft.Sql/servers";
    }
}