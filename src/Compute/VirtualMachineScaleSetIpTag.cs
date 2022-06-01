// Licensed under the MIT License.  See LICENSE in the project root for license information.

using System;
using System.CodeDom.Compiler;
using System.Text.Json.Serialization;
using AzureDesignStudio.AzureResources.Base;

namespace AzureDesignStudio.AzureResources.Compute
{
    /// <summary>
    /// Contains the IP tag associated with the public IP address.
    /// </summary>
    [GeneratedCode("ArmTypeGenerator", "0.1.8.0")]
    public partial class VirtualMachineScaleSetIpTag
    {
        /// <summary>
        /// IP tag type. Example: FirstPartyUsage.
        /// </summary>
        [JsonPropertyName("ipTagType")]
        public string IpTagType { get; set; }

        /// <summary>
        /// IP tag associated with the public IP. Example: SQL, Storage etc.
        /// </summary>
        [JsonPropertyName("tag")]
        public string Tag { get; set; }
    }
}