// Licensed under the MIT License.  See LICENSE in the project root for license information.

using System;
using System.CodeDom.Compiler;
using System.Text.Json.Serialization;
using AzureDesignStudio.AzureResources.Base;

namespace AzureDesignStudio.AzureResources.Network
{
    /// <summary>
    /// The storage location for a packet capture session.
    /// </summary>
    [GeneratedCode("ArmTypeGenerator", "0.1.8.0")]
    public partial class PacketCaptureStorageLocation
    {
        /// <summary>
        /// The ID of the storage account to save the packet capture session. Required if no local file path is provided.
        /// </summary>
        [JsonPropertyName("storageId")]
        public string StorageId { get; set; }

        /// <summary>
        /// The URI of the storage path to save the packet capture. Must be a well-formed URI describing the location to save the packet capture.
        /// </summary>
        [JsonPropertyName("storagePath")]
        public string StoragePath { get; set; }

        /// <summary>
        /// A valid local path on the targeting VM. Must include the name of the capture file (*.cap). For linux virtual machine it must start with /var/captures. Required if no storage ID is provided, otherwise optional.
        /// </summary>
        [JsonPropertyName("filePath")]
        public string FilePath { get; set; }
    }
}