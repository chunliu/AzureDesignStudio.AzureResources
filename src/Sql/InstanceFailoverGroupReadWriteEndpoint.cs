using System;
using System.CodeDom.Compiler;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using AzureDesignStudio.AzureResources.Base;

namespace AzureDesignStudio.AzureResources.Sql
{
    /// <summary>
    /// Read-write endpoint of the failover group instance.
    /// </summary>
    [GeneratedCode("Microsoft.Json.Schema.ToDotNet", "1.1.3.0")]
    public partial class InstanceFailoverGroupReadWriteEndpoint
    {
        /// <summary>
        /// Failover policy of the read-write endpoint for the failover group. If failoverPolicy is Automatic then failoverWithDataLossGracePeriodMinutes is required.
        /// </summary>
        [Required]
        [JsonPropertyName("failoverPolicy")]
        public string FailoverPolicy { get; set; }

        /// <summary>
        /// Grace period before failover with data loss is attempted for the read-write endpoint. If failoverPolicy is Automatic then failoverWithDataLossGracePeriodMinutes is required.
        /// </summary>
        [JsonPropertyName("failoverWithDataLossGracePeriodMinutes")]
        public int FailoverWithDataLossGracePeriodMinutes { get; set; }
    }
}