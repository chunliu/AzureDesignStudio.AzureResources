// Licensed under the MIT License.  See LICENSE in the project root for license information.

using System;
using System.CodeDom.Compiler;
using System.Text.Json.Serialization;
using AzureDesignStudio.AzureResources.Base;

namespace AzureDesignStudio.AzureResources.Compute
{
    /// <summary>
    /// Describes the properties of a Proximity Placement Group.
    /// </summary>
    [GeneratedCode("ArmTypeGenerator", "0.1.8.0")]
    public partial class ProximityPlacementGroupProperties
    {
        /// <summary>
        /// Instance view status.
        /// </summary>
        [JsonPropertyName("colocationStatus")]
        public InstanceViewStatus ColocationStatus { get; set; }

        /// <summary>
        /// Specifies the type of the proximity placement group. <br><br> Possible values are: <br><br> **Standard** : Co-locate resources within an Azure region or Availability Zone. <br><br> **Ultra** : For future use.
        /// </summary>
        [JsonPropertyName("proximityPlacementGroupType")]
        public string ProximityPlacementGroupType { get; set; }
    }
}