// Licensed under the MIT License.  See LICENSE in the project root for license information.

using System;
using System.CodeDom.Compiler;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using AzureDesignStudio.AzureResources.Base;

namespace AzureDesignStudio.AzureResources.Compute
{
    /// <summary>
    /// Describes the target region information.
    /// </summary>
    [GeneratedCode("ArmTypeGenerator", "0.1.8.0")]
    public partial class TargetRegion
    {
        /// <summary>
        /// Optional. Allows users to provide customer managed keys for encrypting the OS and data disks in the gallery artifact.
        /// </summary>
        [JsonPropertyName("encryption")]
        public EncryptionImages Encryption { get; set; }

        /// <summary>
        /// The name of the region.
        /// </summary>
        [Required]
        [JsonPropertyName("name")]
        public string Name { get; set; }

        /// <summary>
        /// The number of replicas of the Image Version to be created per region. This property is updatable.
        /// </summary>
        [JsonPropertyName("regionalReplicaCount")]
        public int RegionalReplicaCount { get; set; }

        /// <summary>
        /// Specifies the storage account type to be used to store the image. This property is not updatable.
        /// </summary>
        [JsonPropertyName("storageAccountType")]
        public string StorageAccountType { get; set; }
    }
}