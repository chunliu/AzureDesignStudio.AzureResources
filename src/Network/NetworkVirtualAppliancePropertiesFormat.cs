// Licensed under the MIT License.  See LICENSE in the project root for license information.

using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using AzureDesignStudio.AzureResources.Base;

namespace AzureDesignStudio.AzureResources.Network
{
    /// <summary>
    /// Network Virtual Appliance definition.
    /// </summary>
    [GeneratedCode("ArmTypeGenerator", "0.1.8.0")]
    public partial class NetworkVirtualAppliancePropertiesFormat
    {
        /// <summary>
        /// Network Virtual Appliance SKU.
        /// </summary>
        [JsonPropertyName("nvaSku")]
        public VirtualApplianceSkuProperties NvaSku { get; set; }

        /// <summary>
        /// BootStrapConfigurationBlobs storage URLs.
        /// </summary>
        [JsonPropertyName("bootStrapConfigurationBlobs")]
        public IList<string> BootStrapConfigurationBlobs { get; set; }

        /// <summary>
        /// The Virtual Hub where Network Virtual Appliance is being deployed.
        /// </summary>
        [JsonPropertyName("virtualHub")]
        public SubResource VirtualHub { get; set; }

        /// <summary>
        /// CloudInitConfigurationBlob storage URLs.
        /// </summary>
        [JsonPropertyName("cloudInitConfigurationBlobs")]
        public IList<string> CloudInitConfigurationBlobs { get; set; }

        /// <summary>
        /// CloudInitConfiguration string in plain text.
        /// </summary>
        [JsonPropertyName("cloudInitConfiguration")]
        public string CloudInitConfiguration { get; set; }

        /// <summary>
        /// VirtualAppliance ASN.
        /// </summary>
        [JsonPropertyName("virtualApplianceAsn")]
        public int VirtualApplianceAsn { get; set; }
    }
}