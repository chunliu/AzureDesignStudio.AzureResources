// Licensed under the MIT License.  See LICENSE in the project root for license information.

using System;
using System.CodeDom.Compiler;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using AzureDesignStudio.AzureResources.Base;

namespace AzureDesignStudio.AzureResources.Compute
{
    /// <summary>
    /// Microsoft.Compute/diskEncryptionSets
    /// </summary>
    [GeneratedCode("ArmTypeGenerator", "0.1.8.0")]
    public partial class DiskEncryptionSets : ResourceBase
    {
        [Required]
        [JsonPropertyName("apiVersion")]
        public override string ApiVersion => "2022-03-02";

        /// <summary>
        /// The managed identity for the disk encryption set. It should be given permission on the key vault before it can be used to encrypt disks.
        /// </summary>
        [JsonPropertyName("identity")]
        public EncryptionSetIdentity Identity { get; set; }
        [Required]
        [JsonPropertyName("properties")]
        public EncryptionSetProperties Properties { get; set; }

        [Required]
        [JsonPropertyName("type")]
        public override string Type => "Microsoft.Compute/diskEncryptionSets";
    }
}