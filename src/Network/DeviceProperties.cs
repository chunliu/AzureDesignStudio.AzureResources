// Licensed under the MIT License.  See LICENSE in the project root for license information.

using System;
using System.CodeDom.Compiler;
using System.Text.Json.Serialization;
using AzureDesignStudio.AzureResources.Base;

namespace AzureDesignStudio.AzureResources.Network
{
    /// <summary>
    /// List of properties of the device.
    /// </summary>
    [GeneratedCode("ArmTypeGenerator", "0.1.8.0")]
    public partial class DeviceProperties
    {
        /// <summary>
        /// Name of the device Vendor.
        /// </summary>
        [JsonPropertyName("deviceVendor")]
        public string DeviceVendor { get; set; }

        /// <summary>
        /// Model of the device.
        /// </summary>
        [JsonPropertyName("deviceModel")]
        public string DeviceModel { get; set; }

        /// <summary>
        /// Link speed.
        /// </summary>
        [JsonPropertyName("linkSpeedInMbps")]
        public int LinkSpeedInMbps { get; set; }
    }
}