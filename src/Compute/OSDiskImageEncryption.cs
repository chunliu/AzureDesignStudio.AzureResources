// Licensed under the MIT License.  See LICENSE in the project root for license information.

using System;
using System.CodeDom.Compiler;
using System.Text.Json.Serialization;
using AzureDesignStudio.AzureResources.Base;

namespace AzureDesignStudio.AzureResources.Compute
{
    /// <summary>
    /// Contains encryption settings for an OS disk image.
    /// </summary>
    [GeneratedCode("ArmTypeGenerator", "0.1.8.0")]
    public partial class OSDiskImageEncryption
    {
        /// <summary>
        /// A relative URI containing the resource ID of the disk encryption set.
        /// </summary>
        [JsonPropertyName("diskEncryptionSetId")]
        public string DiskEncryptionSetId { get; set; }
    }
}