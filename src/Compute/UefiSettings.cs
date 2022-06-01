// Licensed under the MIT License.  See LICENSE in the project root for license information.

using System;
using System.CodeDom.Compiler;
using System.Text.Json.Serialization;
using AzureDesignStudio.AzureResources.Base;

namespace AzureDesignStudio.AzureResources.Compute
{
    /// <summary>
    /// Specifies the security settings like secure boot and vTPM used while creating the virtual machine. <br><br>Minimum api-version: 2020-12-01
    /// </summary>
    [GeneratedCode("ArmTypeGenerator", "0.1.8.0")]
    public partial class UefiSettings
    {
        /// <summary>
        /// Specifies whether secure boot should be enabled on the virtual machine. <br><br>Minimum api-version: 2020-12-01
        /// </summary>
        [JsonPropertyName("secureBootEnabled")]
        public bool SecureBootEnabled { get; set; }

        /// <summary>
        /// Specifies whether vTPM should be enabled on the virtual machine. <br><br>Minimum api-version: 2020-12-01
        /// </summary>
        [JsonPropertyName("vTpmEnabled")]
        public bool VTpmEnabled { get; set; }
    }
}