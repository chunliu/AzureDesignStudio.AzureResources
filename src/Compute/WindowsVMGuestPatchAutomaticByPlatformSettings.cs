// Licensed under the MIT License.  See LICENSE in the project root for license information.

using System;
using System.CodeDom.Compiler;
using System.Text.Json.Serialization;
using AzureDesignStudio.AzureResources.Base;

namespace AzureDesignStudio.AzureResources.Compute
{
    /// <summary>
    /// Specifies additional settings to be applied when patch mode AutomaticByPlatform is selected in Windows patch settings.
    /// </summary>
    [GeneratedCode("ArmTypeGenerator", "0.1.8.0")]
    public partial class WindowsVMGuestPatchAutomaticByPlatformSettings
    {
        /// <summary>
        /// Specifies the reboot setting for all AutomaticByPlatform patch installation operations.
        /// </summary>
        [JsonPropertyName("rebootSetting")]
        public string RebootSetting { get; set; }
    }
}