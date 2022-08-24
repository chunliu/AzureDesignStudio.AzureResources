// Licensed under the MIT License.  See LICENSE in the project root for license information.

using System;
using System.CodeDom.Compiler;
using System.Text.Json.Serialization;
using AzureDesignStudio.AzureResources.Base;

namespace AzureDesignStudio.AzureResources.Compute
{
    /// <summary>
    /// Specifies the Security profile settings for the virtual machine or virtual machine scale set.
    /// </summary>
    [GeneratedCode("ArmTypeGenerator", "0.1.8.0")]
    public partial class SecurityProfile
    {
        /// <summary>
        /// This property can be used by user in the request to enable or disable the Host Encryption for the virtual machine or virtual machine scale set. This will enable the encryption for all the disks including Resource/Temp disk at host itself. <br><br> Default: The Encryption at host will be disabled unless this property is set to true for the resource.
        /// </summary>
        [JsonPropertyName("encryptionAtHost")]
        public bool EncryptionAtHost { get; set; }

        /// <summary>
        /// Specifies the SecurityType of the virtual machine. It has to be set to any specified value to enable UefiSettings. <br><br> Default: UefiSettings will not be enabled unless this property is set.
        /// </summary>
        [JsonPropertyName("securityType")]
        public string SecurityType { get; set; }

        /// <summary>
        /// Specifies the security settings like secure boot and vTPM used while creating the virtual machine. <br><br>Minimum api-version: 2020-12-01
        /// </summary>
        [JsonPropertyName("uefiSettings")]
        public UefiSettings UefiSettings { get; set; }
    }
}