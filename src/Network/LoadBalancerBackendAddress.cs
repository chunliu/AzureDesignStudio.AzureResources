// Licensed under the MIT License.  See LICENSE in the project root for license information.

using System.CodeDom.Compiler;
using System.Text.Json.Serialization;

namespace AzureDesignStudio.AzureResources.Network
{
    /// <summary>
    /// LoadBalancerBackendAddress
    /// </summary>
    [GeneratedCode("ArmTypeGenerator", "0.1.3.54561")]
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