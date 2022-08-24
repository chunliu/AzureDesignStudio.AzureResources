// Licensed under the MIT License.  See LICENSE in the project root for license information.

using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using AzureDesignStudio.AzureResources.Base;

namespace AzureDesignStudio.AzureResources.Compute
{
    /// <summary>
    /// Network Profile for the cloud service.
    /// </summary>
    [GeneratedCode("ArmTypeGenerator", "0.1.8.0")]
    public partial class CloudServiceNetworkProfile
    {
        /// <summary>
        /// List of Load balancer configurations. Cloud service can have up to two load balancer configurations, corresponding to a Public Load Balancer and an Internal Load Balancer.
        /// </summary>
        [JsonPropertyName("loadBalancerConfigurations")]
        public IList<LoadBalancerConfiguration> LoadBalancerConfigurations { get; set; }
        [JsonPropertyName("slotType")]
        public string SlotType { get; set; }
        [JsonPropertyName("swappableCloudService")]
        public SubResource SwappableCloudService { get; set; }
    }
}