// Licensed under the MIT License.  See LICENSE in the project root for license information.

using System;
using System.CodeDom.Compiler;
using System.Text.Json.Serialization;
using AzureDesignStudio.AzureResources.Base;

namespace AzureDesignStudio.AzureResources.Compute
{
    /// <summary>
    /// Enables or disables a capability on the dedicated host group.<br><br>Minimum api-version: 2022-03-01.
    /// </summary>
    [GeneratedCode("ArmTypeGenerator", "0.1.8.0")]
    public partial class DedicatedHostGroupPropertiesAdditionalCapabilities
    {
        /// <summary>
        /// The flag that enables or disables a capability to have UltraSSD Enabled Virtual Machines on Dedicated Hosts of the Dedicated Host Group. For the Virtual Machines to be UltraSSD Enabled, UltraSSDEnabled flag for the resource needs to be set true as well. The value is defaulted to 'false' when not provided. Please refer to https://docs.microsoft.com/en-us/azure/virtual-machines/disks-enable-ultra-ssd for more details on Ultra SSD feature. <br><br>NOTE: The ultraSSDEnabled setting can only be enabled for Host Groups that are created as zonal. <br><br>Minimum api-version: 2022-03-01.
        /// </summary>
        [JsonPropertyName("ultraSSDEnabled")]
        public bool UltraSSDEnabled { get; set; }
    }
}