using System;
using System.CodeDom.Compiler;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using AzureDesignStudio.AzureResources.Base;

namespace AzureDesignStudio.AzureResources.Sql
{
    /// <summary>
    /// Properties of a job agent.
    /// </summary>
    [GeneratedCode("Microsoft.Json.Schema.ToDotNet", "1.1.3.0")]
    public partial class JobAgentProperties
    {
        /// <summary>
        /// Resource ID of the database to store job metadata in.
        /// </summary>
        [Required]
        [JsonPropertyName("databaseId")]
        public string DatabaseId { get; set; }
    }
}