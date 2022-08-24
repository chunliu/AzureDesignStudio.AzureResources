// Licensed under the MIT License.  See LICENSE in the project root for license information.

using System;
using System.CodeDom.Compiler;
using System.Text.Json.Serialization;
using AzureDesignStudio.AzureResources.Base;

namespace AzureDesignStudio.AzureResources.Compute
{
    /// <summary>
    /// Contains the security related information for the resource.
    /// </summary>
    [GeneratedCode("ArmTypeGenerator", "0.1.8.0")]
    public partial class DiskSecurityProfile
    {
        /// <summary>
        /// ResourceId of the disk encryption set associated to Confidential VM supported disk encrypted with customer managed key
        /// </summary>
        [JsonPropertyName("secureVMDiskEncryptionSetId")]
        public string SecureVMDiskEncryptionSetId { get; set; }
        [JsonPropertyName("securityType")]
        public string SecurityType { get; set; }
    }
}