// Licensed under the MIT License.  See LICENSE in the project root for license information.

using System;
using System.CodeDom.Compiler;
using System.Text.Json.Serialization;
using AzureDesignStudio.AzureResources.Base;

namespace AzureDesignStudio.AzureResources.Compute
{
    /// <summary>
    /// Describes the properties of a Virtual Machine Extension.
    /// </summary>
    [GeneratedCode("ArmTypeGenerator", "0.1.8.0")]
    public partial class VirtualMachineExtensionProperties
    {
        /// <summary>
        /// Indicates whether the extension should use a newer minor version if one is available at deployment time. Once deployed, however, the extension will not upgrade minor versions unless redeployed, even with this property set to true.
        /// </summary>
        [JsonPropertyName("autoUpgradeMinorVersion")]
        public bool AutoUpgradeMinorVersion { get; set; }

        /// <summary>
        /// Indicates whether the extension should be automatically upgraded by the platform if there is a newer version of the extension available.
        /// </summary>
        [JsonPropertyName("enableAutomaticUpgrade")]
        public bool EnableAutomaticUpgrade { get; set; }

        /// <summary>
        /// How the extension handler should be forced to update even if the extension configuration has not changed.
        /// </summary>
        [JsonPropertyName("forceUpdateTag")]
        public string ForceUpdateTag { get; set; }

        /// <summary>
        /// The instance view of a virtual machine extension.
        /// </summary>
        [JsonPropertyName("instanceView")]
        public VirtualMachineExtensionInstanceView InstanceView { get; set; }

        /// <summary>
        /// The extension can contain either protectedSettings or protectedSettingsFromKeyVault or no protected settings at all.
        /// </summary>
        [JsonPropertyName("protectedSettings")]
        public object ProtectedSettings { get; set; }

        /// <summary>
        /// The extensions protected settings that are passed by reference, and consumed from key vault
        /// </summary>
        [JsonPropertyName("protectedSettingsFromKeyVault")]
        public object ProtectedSettingsFromKeyVault { get; set; }

        /// <summary>
        /// The name of the extension handler publisher.
        /// </summary>
        [JsonPropertyName("publisher")]
        public string Publisher { get; set; }

        /// <summary>
        /// Json formatted public settings for the extension.
        /// </summary>
        [JsonPropertyName("settings")]
        public object Settings { get; set; }

        /// <summary>
        /// Indicates whether failures stemming from the extension will be suppressed (Operational failures such as not connecting to the VM will not be suppressed regardless of this value). The default is false.
        /// </summary>
        [JsonPropertyName("suppressFailures")]
        public bool SuppressFailures { get; set; }

        /// <summary>
        /// Specifies the type of the extension; an example is "CustomScriptExtension".
        /// </summary>
        [JsonPropertyName("type")]
        public string Type { get; set; }

        /// <summary>
        /// Specifies the version of the script handler.
        /// </summary>
        [JsonPropertyName("typeHandlerVersion")]
        public string TypeHandlerVersion { get; set; }
    }
}