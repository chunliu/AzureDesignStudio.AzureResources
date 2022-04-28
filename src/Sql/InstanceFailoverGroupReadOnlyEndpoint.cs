using System;
using System.CodeDom.Compiler;
using System.Text.Json.Serialization;
using AzureDesignStudio.AzureResources.Base;

namespace AzureDesignStudio.AzureResources.Sql
{
    /// <summary>
    /// Read-only endpoint of the failover group instance.
    /// </summary>
    [GeneratedCode("Microsoft.Json.Schema.ToDotNet", "1.1.3.0")]
    public partial class InstanceFailoverGroupReadOnlyEndpoint
    {
        /// <summary>
        /// Failover policy of the read-only endpoint for the failover group.
        /// </summary>
        [JsonPropertyName("failoverPolicy")]
        public string FailoverPolicy { get; set; }
    }
}