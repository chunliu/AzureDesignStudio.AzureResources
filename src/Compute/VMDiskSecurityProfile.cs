// Licensed under the MIT License.  See LICENSE in the project root for license information.

using System;
using System.CodeDom.Compiler;
using System.Text.Json.Serialization;
using AzureDesignStudio.AzureResources.Base;

namespace AzureDesignStudio.AzureResources.Compute
{
    /// <summary>
    /// Specifies the security profile settings for the managed disk. <br><br> NOTE: It can only be set for Confidential VMs
    /// </summary>
    [GeneratedCode("ArmTypeGenerator", "0.1.8.0")]
    public partial class VMDiskSecurityProfile
    {
        /// <summary>
        /// Describes the parameter of customer managed disk encryption set resource id that can be specified for disk. <br><br> NOTE: The disk encryption set resource id can only be specified for managed disk. Please refer https://aka.ms/mdssewithcmkoverview for more details.
        /// </summary>
        [JsonPropertyName("diskEncryptionSet")]
        public DiskEncryptionSetParameters DiskEncryptionSet { get; set; }

        /// <summary>
        /// Specifies the EncryptionType of the managed disk. <br> It is set to DiskWithVMGuestState for encryption of the managed disk along with VMGuestState blob, and VMGuestStateOnly for encryption of just the VMGuestState blob. <br><br> NOTE: It can be set for only Confidential VMs.
        /// </summary>
        [JsonPropertyName("securityEncryptionType")]
        public string SecurityEncryptionType { get; set; }
    }
}