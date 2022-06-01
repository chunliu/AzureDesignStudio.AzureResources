// Licensed under the MIT License.  See LICENSE in the project root for license information.

using System;
using System.CodeDom.Compiler;
using System.Text.Json.Serialization;
using AzureDesignStudio.AzureResources.Base;

namespace AzureDesignStudio.AzureResources.Compute
{
    /// <summary>
    /// Describes an upgrade policy - automatic, manual, or rolling.
    /// </summary>
    [GeneratedCode("ArmTypeGenerator", "0.1.8.0")]
    public partial class UpgradePolicy
    {
        /// <summary>
        /// The configuration parameters used for performing automatic OS upgrade.
        /// </summary>
        [JsonPropertyName("automaticOSUpgradePolicy")]
        public AutomaticOSUpgradePolicy AutomaticOSUpgradePolicy { get; set; }

        /// <summary>
        /// Specifies the mode of an upgrade to virtual machines in the scale set.<br /><br /> Possible values are:<br /><br /> **Manual** - You  control the application of updates to virtual machines in the scale set. You do this by using the manualUpgrade action.<br /><br /> **Automatic** - All virtual machines in the scale set are  automatically updated at the same time.
        /// </summary>
        [JsonPropertyName("mode")]
        public string Mode { get; set; }

        /// <summary>
        /// The configuration parameters used while performing a rolling upgrade.
        /// </summary>
        [JsonPropertyName("rollingUpgradePolicy")]
        public RollingUpgradePolicy RollingUpgradePolicy { get; set; }
    }
}