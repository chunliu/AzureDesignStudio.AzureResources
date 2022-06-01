// Licensed under the MIT License.  See LICENSE in the project root for license information.

using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using AzureDesignStudio.AzureResources.Base;

namespace AzureDesignStudio.AzureResources.Compute
{
    /// <summary>
    /// Optional. Allows users to provide customer managed keys for encrypting the OS and data disks in the gallery artifact.
    /// </summary>
    [GeneratedCode("ArmTypeGenerator", "0.1.8.0")]
    public partial class EncryptionImages
    {
        /// <summary>
        /// A list of encryption specifications for data disk images.
        /// </summary>
        [JsonPropertyName("dataDiskImages")]
        public IList<DataDiskImageEncryption> DataDiskImages { get; set; }

        /// <summary>
        /// Contains encryption settings for an OS disk image.
        /// </summary>
        [JsonPropertyName("osDiskImage")]
        public OSDiskImageEncryption OsDiskImage { get; set; }
    }
}