using System;
using System.CodeDom.Compiler;
using System.Text.Json.Serialization;
using AzureDesignStudio.AzureResources.Base;

namespace AzureDesignStudio.AzureResources.Sql
{
    /// <summary>
    /// Partner region information for the failover group.
    /// </summary>
    [GeneratedCode("Microsoft.Json.Schema.ToDotNet", "1.1.3.0")]
    public partial class PartnerRegionInfo
    {
        /// <summary>
        /// Geo location of the partner managed instances.
        /// </summary>
        [JsonPropertyName("location")]
        public string Location { get; set; }
    }
}