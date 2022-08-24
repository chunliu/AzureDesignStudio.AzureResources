// Licensed under the MIT License.  See LICENSE in the project root for license information.

using System;
using System.CodeDom.Compiler;
using System.Text.Json.Serialization;
using AzureDesignStudio.AzureResources.Base;

namespace AzureDesignStudio.AzureResources.Compute
{
    /// <summary>
    /// The configuration parameters used for performing automatic OS upgrade.
    /// </summary>
    [GeneratedCode("ArmTypeGenerator", "0.1.8.0")]
    public partial class AutomaticOSUpgradePolicy
    {
        /// <summary>
        /// Whether OS image rollback feature should be disabled. Default value is false.
        /// </summary>
        [JsonPropertyName("disableAutomaticRollback")]
        public bool DisableAutomaticRollback { get; set; }

        /// <summary>
        /// Indicates whether OS upgrades should automatically be applied to scale set instances in a rolling fashion when a newer version of the OS image becomes available. Default value is false. <br><br> If this is set to true for Windows based scale sets, [enableAutomaticUpdates](https://docs.microsoft.com/dotnet/api/microsoft.azure.management.compute.models.windowsconfiguration.enableautomaticupdates?view=azure-dotnet) is automatically set to false and cannot be set to true.
        /// </summary>
        [JsonPropertyName("enableAutomaticOSUpgrade")]
        public bool EnableAutomaticOSUpgrade { get; set; }

        /// <summary>
        /// Indicates whether rolling upgrade policy should be used during Auto OS Upgrade. Default value is false. Auto OS Upgrade will fallback to the default policy if no policy is defined on the VMSS.
        /// </summary>
        [JsonPropertyName("useRollingUpgradePolicy")]
        public bool UseRollingUpgradePolicy { get; set; }
    }
}