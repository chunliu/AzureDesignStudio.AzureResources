// Licensed under the MIT License.  See LICENSE in the project root for license information.

using System;
using System.CodeDom.Compiler;
using System.Text.Json.Serialization;
using AzureDesignStudio.AzureResources.Base;

namespace AzureDesignStudio.AzureResources.Sql
{
    /// <summary>
    /// Pairs of Managed Instances in the failover group.
    /// </summary>
    [GeneratedCode("ArmTypeGenerator", "0.1.8.0")]
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