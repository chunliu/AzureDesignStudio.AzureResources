// Licensed under the MIT License.  See LICENSE in the project root for license information.

using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using AzureDesignStudio.AzureResources.Base;

namespace AzureDesignStudio.AzureResources.Compute
{
    /// <summary>
    /// Extension Properties.
    /// </summary>
    [GeneratedCode("ArmTypeGenerator", "0.1.8.0")]
    public partial class CloudServiceExtensionProperties
    {
        /// <summary>
        /// Explicitly specify whether platform can automatically upgrade typeHandlerVersion to higher minor versions when they become available.
        /// </summary>
        [JsonPropertyName("autoUpgradeMinorVersion")]
        public bool AutoUpgradeMinorVersion { get; set; }

        /// <summary>
        /// Tag to force apply the provided public and protected settings.
        [JsonPropertyName("forceUpdateTag")]
        public string ForceUpdateTag { get; set; }

        /// <summary>
        /// Protected settings for the extension which are encrypted before sent to the role instance.
        /// </summary>
        [JsonPropertyName("protectedSettings")]
        public object ProtectedSettings { get; set; }

        /// <summary>
        /// Protected settings for the extension, referenced using KeyVault which are encrypted before sent to the role instance.
        /// </summary>
        [JsonPropertyName("protectedSettingsFromKeyVault")]
        public CloudServiceVaultAndSecretReference ProtectedSettingsFromKeyVault { get; set; }

        /// <summary>
        /// The name of the extension handler publisher.
        /// </summary>
        [JsonPropertyName("publisher")]
        public string Publisher { get; set; }

        /// <summary>
        /// Optional list of roles to apply this extension. If property is not specified or '*' is specified, extension is applied to all roles in the cloud service.
        /// </summary>
        [JsonPropertyName("rolesAppliedTo")]
        public IList<string> RolesAppliedTo { get; set; }

        /// <summary>
        /// Public settings for the extension. For JSON extensions, this is the JSON settings for the extension. For XML Extension (like RDP), this is the XML setting for the extension.
        /// </summary>
        [JsonPropertyName("settings")]
        public object Settings { get; set; }

        /// <summary>
        /// Specifies the type of the extension.
        /// </summary>
        [JsonPropertyName("type")]
        public string Type { get; set; }

        /// <summary>
        /// Specifies the version of the extension. Specifies the version of the extension. If this element is not specified or an asterisk (*) is used as the value, the latest version of the extension is used. If the value is specified with a major version number and an asterisk as the minor version number (X.), the latest minor version of the specified major version is selected. If a major version number and a minor version number are specified (X.Y), the specific extension version is selected. If a version is specified, an auto-upgrade is performed on the role instance.
        /// </summary>
        [JsonPropertyName("typeHandlerVersion")]
        public string TypeHandlerVersion { get; set; }
    }
}