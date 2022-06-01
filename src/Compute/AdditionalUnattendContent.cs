// Licensed under the MIT License.  See LICENSE in the project root for license information.

using System;
using System.CodeDom.Compiler;
using System.Text.Json.Serialization;
using AzureDesignStudio.AzureResources.Base;

namespace AzureDesignStudio.AzureResources.Compute
{
    /// <summary>
    /// Specifies additional XML formatted information that can be included in the Unattend.xml file, which is used by Windows Setup. Contents are defined by setting name, component name, and the pass in which the content is applied.
    /// </summary>
    [GeneratedCode("ArmTypeGenerator", "0.1.8.0")]
    public partial class AdditionalUnattendContent
    {
        /// <summary>
        /// The component name. Currently, the only allowable value is Microsoft-Windows-Shell-Setup.
        /// </summary>
        [JsonPropertyName("componentName")]
        public string ComponentName { get; set; }

        /// <summary>
        /// Specifies the XML formatted content that is added to the unattend.xml file for the specified path and component. The XML must be less than 4KB and must include the root element for the setting or feature that is being inserted.
        /// </summary>
        [JsonPropertyName("content")]
        public string Content { get; set; }

        /// <summary>
        /// The pass name. Currently, the only allowable value is OobeSystem.
        /// </summary>
        [JsonPropertyName("passName")]
        public string PassName { get; set; }

        /// <summary>
        /// Specifies the name of the setting to which the content applies. Possible values are: FirstLogonCommands and AutoLogon.
        /// </summary>
        [JsonPropertyName("settingName")]
        public string SettingName { get; set; }
    }
}