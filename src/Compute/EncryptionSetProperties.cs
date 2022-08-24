// Licensed under the MIT License.  See LICENSE in the project root for license information.

using System;
using System.CodeDom.Compiler;
using System.Text.Json.Serialization;
using AzureDesignStudio.AzureResources.Base;

namespace AzureDesignStudio.AzureResources.Compute
{
    [GeneratedCode("ArmTypeGenerator", "0.1.8.0")]
    public partial class EncryptionSetProperties
    {
        /// <summary>
        /// Key Vault Key Url to be used for server side encryption of Managed Disks and Snapshots
        /// </summary>
        [JsonPropertyName("activeKey")]
        public KeyForDiskEncryptionSet ActiveKey { get; set; }
        [JsonPropertyName("encryptionType")]
        public string EncryptionType { get; set; }

        /// <summary>
        /// Multi-tenant application client id to access key vault in a different tenant. Setting the value to 'None' will clear the property.
        /// </summary>
        [JsonPropertyName("federatedClientId")]
        public string FederatedClientId { get; set; }

        /// <summary>
        /// Set this flag to true to enable auto-updating of this disk encryption set to the latest key version.
        /// </summary>
        [JsonPropertyName("rotationToLatestKeyVersionEnabled")]
        public bool RotationToLatestKeyVersionEnabled { get; set; }
    }
}