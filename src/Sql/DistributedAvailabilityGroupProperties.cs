// Licensed under the MIT License.  See LICENSE in the project root for license information.

using System;
using System.CodeDom.Compiler;
using System.Text.Json.Serialization;
using AzureDesignStudio.AzureResources.Base;

namespace AzureDesignStudio.AzureResources.Sql
{
    /// <summary>
    /// The properties of a distributed availability group.
    /// </summary>
    [GeneratedCode("ArmTypeGenerator", "0.1.8.0")]
    public partial class DistributedAvailabilityGroupProperties
    {
        /// <summary>
        /// The primary availability group name
        /// </summary>
        [JsonPropertyName("primaryAvailabilityGroupName")]
        public string PrimaryAvailabilityGroupName { get; set; }

        /// <summary>
        /// The replication mode of a distributed availability group. Parameter will be ignored during link creation.
        /// </summary>
        [JsonPropertyName("replicationMode")]
        public string ReplicationMode { get; set; }

        /// <summary>
        /// The secondary availability group name
        /// </summary>
        [JsonPropertyName("secondaryAvailabilityGroupName")]
        public string SecondaryAvailabilityGroupName { get; set; }

        /// <summary>
        /// The source endpoint
        /// </summary>
        [JsonPropertyName("sourceEndpoint")]
        public string SourceEndpoint { get; set; }

        /// <summary>
        /// The name of the target database
        /// </summary>
        [JsonPropertyName("targetDatabase")]
        public string TargetDatabase { get; set; }
    }
}