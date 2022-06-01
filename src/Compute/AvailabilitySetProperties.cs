// Licensed under the MIT License.  See LICENSE in the project root for license information.

using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using AzureDesignStudio.AzureResources.Base;

namespace AzureDesignStudio.AzureResources.Compute
{
    /// <summary>
    /// The instance view of a resource.
    /// </summary>
    [GeneratedCode("ArmTypeGenerator", "0.1.8.0")]
    public partial class AvailabilitySetProperties
    {
        /// <summary>
        /// Fault Domain count.
        /// </summary>
        [JsonPropertyName("platformFaultDomainCount")]
        public int PlatformFaultDomainCount { get; set; }

        /// <summary>
        /// Update Domain count.
        /// </summary>
        [JsonPropertyName("platformUpdateDomainCount")]
        public int PlatformUpdateDomainCount { get; set; }
        [JsonPropertyName("proximityPlacementGroup")]
        public SubResource ProximityPlacementGroup { get; set; }

        /// <summary>
        /// A list of references to all virtual machines in the availability set.
        /// </summary>
        [JsonPropertyName("virtualMachines")]
        public IList<SubResource> VirtualMachines { get; set; }
    }
}