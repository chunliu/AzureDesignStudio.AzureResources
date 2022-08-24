// Licensed under the MIT License.  See LICENSE in the project root for license information.

using System;
using System.CodeDom.Compiler;
using System.Text.Json.Serialization;
using AzureDesignStudio.AzureResources.Base;

namespace AzureDesignStudio.AzureResources.Sql
{
    /// <summary>
    /// Properties of an elastic pool
    /// </summary>
    [GeneratedCode("ArmTypeGenerator", "0.1.8.0")]
    public partial class ElasticPoolProperties
    {
        /// <summary>
        /// The number of secondary replicas associated with the elastic pool that are used to provide high availability. Applicable only to Hyperscale elastic pools.
        /// </summary>
        [JsonPropertyName("highAvailabilityReplicaCount")]
        public int HighAvailabilityReplicaCount { get; set; }

        /// <summary>
        /// The license type to apply for this elastic pool.
        /// </summary>
        [JsonPropertyName("licenseType")]
        public string LicenseType { get; set; }

        /// <summary>
        /// Maintenance configuration id assigned to the elastic pool. This configuration defines the period when the maintenance updates will will occur.
        /// </summary>
        [JsonPropertyName("maintenanceConfigurationId")]
        public string MaintenanceConfigurationId { get; set; }

        /// <summary>
        /// The storage limit for the database elastic pool in bytes.
        /// </summary>
        [JsonPropertyName("maxSizeBytes")]
        public int MaxSizeBytes { get; set; }

        /// <summary>
        /// Minimal capacity that serverless pool will not shrink below, if not paused
        /// </summary>
        [JsonPropertyName("minCapacity")]
        public double MinCapacity { get; set; }

        /// <summary>
        /// Per database settings of an elastic pool.
        /// </summary>
        [JsonPropertyName("perDatabaseSettings")]
        public ElasticPoolPerDatabaseSettings PerDatabaseSettings { get; set; }

        /// <summary>
        /// Whether or not this elastic pool is zone redundant, which means the replicas of this elastic pool will be spread across multiple availability zones.
        /// </summary>
        [JsonPropertyName("zoneRedundant")]
        public bool ZoneRedundant { get; set; }
    }
}