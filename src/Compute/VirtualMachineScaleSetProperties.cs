// Licensed under the MIT License.  See LICENSE in the project root for license information.

using System;
using System.CodeDom.Compiler;
using System.Text.Json.Serialization;
using AzureDesignStudio.AzureResources.Base;

namespace AzureDesignStudio.AzureResources.Compute
{
    /// <summary>
    /// Describes the properties of a Virtual Machine Scale Set.
    /// </summary>
    [GeneratedCode("ArmTypeGenerator", "0.1.8.0")]
    public partial class VirtualMachineScaleSetProperties
    {
        /// <summary>
        /// Enables or disables a capability on the virtual machine or virtual machine scale set.
        /// </summary>
        [JsonPropertyName("additionalCapabilities")]
        public AdditionalCapabilities AdditionalCapabilities { get; set; }

        /// <summary>
        /// Specifies the configuration parameters for automatic repairs on the virtual machine scale set.
        /// </summary>
        [JsonPropertyName("automaticRepairsPolicy")]
        public AutomaticRepairsPolicy AutomaticRepairsPolicy { get; set; }

        /// <summary>
        /// When Overprovision is enabled, extensions are launched only on the requested number of VMs which are finally kept. This property will hence ensure that the extensions do not run on the extra overprovisioned VMs.
        /// </summary>
        [JsonPropertyName("doNotRunExtensionsOnOverprovisionedVMs")]
        public bool DoNotRunExtensionsOnOverprovisionedVMs { get; set; }
        [JsonPropertyName("hostGroup")]
        public SubResource HostGroup { get; set; }

        /// <summary>
        /// Specifies the orchestration mode for the virtual machine scale set.
        /// </summary>
        [JsonPropertyName("orchestrationMode")]
        public string OrchestrationMode { get; set; }

        /// <summary>
        /// Specifies whether the Virtual Machine Scale Set should be overprovisioned.
        /// </summary>
        [JsonPropertyName("overprovision")]
        public bool Overprovision { get; set; }

        /// <summary>
        /// Fault Domain count for each placement group.
        /// </summary>
        [JsonPropertyName("platformFaultDomainCount")]
        public int PlatformFaultDomainCount { get; set; }
        [JsonPropertyName("proximityPlacementGroup")]
        public SubResource ProximityPlacementGroup { get; set; }

        /// <summary>
        /// Describes a scale-in policy for a virtual machine scale set.
        /// </summary>
        [JsonPropertyName("scaleInPolicy")]
        public ScaleInPolicy ScaleInPolicy { get; set; }

        /// <summary>
        /// When true this limits the scale set to a single placement group, of max size 100 virtual machines. NOTE: If singlePlacementGroup is true, it may be modified to false. However, if singlePlacementGroup is false, it may not be modified to true.
        /// </summary>
        [JsonPropertyName("singlePlacementGroup")]
        public bool SinglePlacementGroup { get; set; }

        /// <summary>
        /// Specifies the Spot-Try-Restore properties for the virtual machine scale set. <br><br> With this property customer can enable or disable automatic restore of the evicted Spot VMSS VM instances opportunistically based on capacity availability and pricing constraint.
        /// </summary>
        [JsonPropertyName("spotRestorePolicy")]
        public SpotRestorePolicy SpotRestorePolicy { get; set; }

        /// <summary>
        /// Describes an upgrade policy - automatic, manual, or rolling.
        /// </summary>
        [JsonPropertyName("upgradePolicy")]
        public UpgradePolicy UpgradePolicy { get; set; }

        /// <summary>
        /// Describes a virtual machine scale set virtual machine profile.
        /// </summary>
        [JsonPropertyName("virtualMachineProfile")]
        public VirtualMachineScaleSetVMProfile VirtualMachineProfile { get; set; }

        /// <summary>
        /// Whether to force strictly even Virtual Machine distribution cross x-zones in case there is zone outage. zoneBalance property can only be set if the zones property of the scale set contains more than one zone. If there are no zones or only one zone specified, then zoneBalance property should not be set.
        /// </summary>
        [JsonPropertyName("zoneBalance")]
        public bool ZoneBalance { get; set; }
    }
}