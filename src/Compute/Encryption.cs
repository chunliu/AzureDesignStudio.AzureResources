// Licensed under the MIT License.  See LICENSE in the project root for license information.

using System;
using System.CodeDom.Compiler;
using System.Text.Json.Serialization;
using AzureDesignStudio.AzureResources.Base;

namespace AzureDesignStudio.AzureResources.Compute
{
    /// <summary>
    /// Encryption at rest settings for disk or snapshot
    /// </summary>
    [GeneratedCode("ArmTypeGenerator", "0.1.8.0")]
    public partial class Encryption
    {
        /// <summary>
        /// ResourceId of the disk encryption set to use for enabling encryption at rest.
        /// </summary>
        [JsonPropertyName("diskEncryptionSetId")]
        public string DiskEncryptionSetId { get; set; }
        [JsonPropertyName("type")]
        public string Type { get; set; }
    }
}