using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using AzureDesignStudio.AzureResources.Base;

namespace AzureDesignStudio.AzureResources.Sql
{
    /// <summary>
    /// Microsoft.Sql/servers/databases
    /// </summary>
    [GeneratedCode("Microsoft.Json.Schema.ToDotNet", "1.1.3.0")]
    public partial class ServersDatabases : ResourceBase
    {
        [Required]
        [JsonPropertyName("apiVersion")]
        public override string ApiVersion => "2021-02-01-preview";

        /// <summary>
        /// The database's properties.
        /// </summary>
        [Required]
        [JsonPropertyName("properties")]
        public DatabaseProperties Properties { get; set; }
        [JsonPropertyName("resources")]
        public IList<ServersDatabasesTransparentDataEncryption> Resources { get; set; }

        /// <summary>
        /// An ARM Resource SKU.
        /// </summary>
        [JsonPropertyName("sku")]
        public Sku Sku { get; set; }

        [Required]
        [JsonPropertyName("type")]
        public override string Type => "Microsoft.Sql/servers/databases";
    }
}