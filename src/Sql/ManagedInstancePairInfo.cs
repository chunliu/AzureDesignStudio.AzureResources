using System;
using System.CodeDom.Compiler;
using System.Text.Json.Serialization;
using AzureDesignStudio.AzureResources.Base;

namespace AzureDesignStudio.AzureResources.Sql
{
    /// <summary>
    /// Pairs of Managed Instances in the failover group.
    /// </summary>
    [GeneratedCode("Microsoft.Json.Schema.ToDotNet", "1.1.3.0")]
    public partial class ManagedInstancePairInfo
    {
        /// <summary>
        /// Id of Partner Managed Instance in pair.
        /// </summary>
        [JsonPropertyName("partnerManagedInstanceId")]
        public string PartnerManagedInstanceId { get; set; }

        /// <summary>
        /// Id of Primary Managed Instance in pair.
        /// </summary>
        [JsonPropertyName("primaryManagedInstanceId")]
        public string PrimaryManagedInstanceId { get; set; }
    }
}