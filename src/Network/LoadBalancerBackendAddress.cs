// Licensed under the MIT License.  See LICENSE in the project root for license information.

using System;
using System.CodeDom.Compiler;
using System.Text.Json.Serialization;
using AzureDesignStudio.AzureResources.Base;

namespace AzureDesignStudio.AzureResources.Network
{
    /// <summary>
    /// Load balancer backend addresses.
    /// </summary>
    [GeneratedCode("ArmTypeGenerator", "0.1.8.0")]
    public partial class LoadBalancerBackendAddress
    {
        /// <summary>
        /// Properties of load balancer backend address pool.
        /// </summary>
        [JsonPropertyName("properties")]
        public LoadBalancerBackendAddressPropertiesFormat Properties { get; set; }

        /// <summary>
        /// Name of the backend address.
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; set; }
    }
}