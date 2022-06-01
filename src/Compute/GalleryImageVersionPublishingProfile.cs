// Licensed under the MIT License.  See LICENSE in the project root for license information.

using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using AzureDesignStudio.AzureResources.Base;

namespace AzureDesignStudio.AzureResources.Compute
{
    /// <summary>
    /// The publishing profile of a gallery image Version.
    /// </summary>
    [GeneratedCode("ArmTypeGenerator", "0.1.8.0")]
    public partial class GalleryImageVersionPublishingProfile
    {
        /// <summary>
        /// The end of life date of the gallery image version. This property can be used for decommissioning purposes. This property is updatable.
        /// </summary>
        [JsonPropertyName("endOfLifeDate")]
        public DateTime EndOfLifeDate { get; set; }

        /// <summary>
        /// If set to true, Virtual Machines deployed from the latest version of the Image Definition won't use this Image Version.
        /// </summary>
        [JsonPropertyName("excludeFromLatest")]
        public bool ExcludeFromLatest { get; set; }

        /// <summary>
        /// The number of replicas of the Image Version to be created per region. This property would take effect for a region when regionalReplicaCount is not specified. This property is updatable.
        /// </summary>
        [JsonPropertyName("replicaCount")]
        public int ReplicaCount { get; set; }

        /// <summary>
        /// Optional parameter which specifies the mode to be used for replication. This property is not updatable.
        /// </summary>
        [JsonPropertyName("replicationMode")]
        public string ReplicationMode { get; set; }

        /// <summary>
        /// Specifies the storage account type to be used to store the image. This property is not updatable.
        /// </summary>
        [JsonPropertyName("storageAccountType")]
        public string StorageAccountType { get; set; }

        /// <summary>
        /// The target regions where the Image Version is going to be replicated to. This property is updatable.
        /// </summary>
        [JsonPropertyName("targetRegions")]
        public IList<TargetRegion> TargetRegions { get; set; }
    }
}