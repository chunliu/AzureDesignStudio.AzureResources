// Licensed under the MIT License.  See LICENSE in the project root for license information.

using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using AzureDesignStudio.AzureResources.Base;

namespace AzureDesignStudio.AzureResources.Compute
{
    /// <summary>
    /// Specifies Windows operating system settings on the virtual machine.
    /// </summary>
    [GeneratedCode("ArmTypeGenerator", "0.1.8.0")]
    public partial class WindowsConfiguration
    {
        /// <summary>
        /// Specifies additional base-64 encoded XML formatted information that can be included in the Unattend.xml file, which is used by Windows Setup.
        /// </summary>
        [JsonPropertyName("additionalUnattendContent")]
        public IList<AdditionalUnattendContent> AdditionalUnattendContent { get; set; }

        /// <summary>
        /// Indicates whether Automatic Updates is enabled for the Windows virtual machine. Default value is true. <br><br> For virtual machine scale sets, this property can be updated and updates will take effect on OS reprovisioning.
        /// </summary>
        [JsonPropertyName("enableAutomaticUpdates")]
        public bool EnableAutomaticUpdates { get; set; }

        /// <summary>
        /// Specifies settings related to VM Guest Patching on Windows.
        /// </summary>
        [JsonPropertyName("patchSettings")]
        public PatchSettings PatchSettings { get; set; }

        /// <summary>
        /// Indicates whether virtual machine agent should be provisioned on the virtual machine. <br><br> When this property is not specified in the request body, default behavior is to set it to true.  This will ensure that VM Agent is installed on the VM so that extensions can be added to the VM later.
        /// </summary>
        [JsonPropertyName("provisionVMAgent")]
        public bool ProvisionVMAgent { get; set; }

        /// <summary>
        /// Specifies the time zone of the virtual machine. e.g. "Pacific Standard Time". <br><br> Possible values can be [TimeZoneInfo.Id](https://docs.microsoft.com/dotnet/api/system.timezoneinfo.id?#System_TimeZoneInfo_Id) value from time zones returned by [TimeZoneInfo.GetSystemTimeZones](https://docs.microsoft.com/dotnet/api/system.timezoneinfo.getsystemtimezones).
        /// </summary>
        [JsonPropertyName("timeZone")]
        public string TimeZone { get; set; }

        /// <summary>
        /// Describes Windows Remote Management configuration of the VM
        /// </summary>
        [JsonPropertyName("winRM")]
        public WinRMConfiguration WinRM { get; set; }
    }
}