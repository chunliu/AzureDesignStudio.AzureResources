// Licensed under the MIT License.  See LICENSE in the project root for license information.

using System;
using System.CodeDom.Compiler;
using System.Text.Json.Serialization;
using AzureDesignStudio.AzureResources.Base;

namespace AzureDesignStudio.AzureResources.Compute
{
    /// <summary>
    /// Specifies the Spot-Try-Restore properties for the virtual machine scale set. <br><br> With this property customer can enable or disable automatic restore of the evicted Spot VMSS VM instances opportunistically based on capacity availability and pricing constraint.
    /// </summary>
    [GeneratedCode("ArmTypeGenerator", "0.1.8.0")]
    public partial class SpotRestorePolicy
    {
        /// <summary>
        /// Enables the Spot-Try-Restore feature where evicted VMSS SPOT instances will be tried to be restored opportunistically based on capacity availability and pricing constraints
        /// </summary>
        [JsonPropertyName("enabled")]
        public bool Enabled { get; set; }

        /// <summary>
        /// Timeout value expressed as an ISO 8601 time duration after which the platform will not try to restore the VMSS SPOT instances
        /// </summary>
        [JsonPropertyName("restoreTimeout")]
        public string RestoreTimeout { get; set; }
    }
}