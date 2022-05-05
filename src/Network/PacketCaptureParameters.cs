// Licensed under the MIT License.  See LICENSE in the project root for license information.

using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using AzureDesignStudio.AzureResources.Base;

namespace AzureDesignStudio.AzureResources.Network
{
    /// <summary>
    /// Parameters that define the create packet capture operation.
    /// </summary>
    [GeneratedCode("ArmTypeGenerator", "0.1.8.0")]
    public partial class PacketCaptureParameters
    {
        /// <summary>
        /// The ID of the targeted resource, only VM is currently supported.
        /// </summary>
        [Required]
        [JsonPropertyName("target")]
        public string Target { get; set; }

        /// <summary>
        /// Number of bytes captured per packet, the remaining bytes are truncated.
        /// </summary>
        [JsonPropertyName("bytesToCapturePerPacket")]
        public int BytesToCapturePerPacket { get; set; }

        /// <summary>
        /// Maximum size of the capture output.
        /// </summary>
        [JsonPropertyName("totalBytesPerSession")]
        public int TotalBytesPerSession { get; set; }

        /// <summary>
        /// Maximum duration of the capture session in seconds.
        /// </summary>
        [JsonPropertyName("timeLimitInSeconds")]
        public int TimeLimitInSeconds { get; set; }

        /// <summary>
        /// The storage location for a packet capture session.
        /// </summary>
        [Required]
        [JsonPropertyName("storageLocation")]
        public PacketCaptureStorageLocation StorageLocation { get; set; }

        /// <summary>
        /// A list of packet capture filters.
        /// </summary>
        [JsonPropertyName("filters")]
        public IList<PacketCaptureFilter> Filters { get; set; }
    }
}