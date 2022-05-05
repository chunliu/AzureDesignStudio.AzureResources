// Licensed under the MIT License.  See LICENSE in the project root for license information.

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
    [GeneratedCode("ArmTypeGenerator", "0.1.8.0")]
    public partial class FailoverGroupReadWriteEndpoint
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