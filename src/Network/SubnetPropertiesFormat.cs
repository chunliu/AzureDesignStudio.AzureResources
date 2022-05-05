// Licensed under the MIT License.  See LICENSE in the project root for license information.

using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using AzureDesignStudio.AzureResources.Base;

namespace AzureDesignStudio.AzureResources.Network
{
    /// <summary>
    /// Properties of the subnet.
    /// </summary>
    [GeneratedCode("ArmTypeGenerator", "0.1.8.0")]
    public partial class SubnetPropertiesFormat
    {
        /// <summary>
        /// The address prefix for the subnet.
        /// </summary>
        [Required]
        [JsonPropertyName("addressPrefix")]
        public string AddressPrefix { get; set; }

        /// <summary>
        /// List of address prefixes for the subnet.
        /// </summary>
        [JsonPropertyName("addressPrefixes")]
        public IList<string> AddressPrefixes { get; set; }

        /// <summary>
        /// The reference to the NetworkSecurityGroup resource.
        /// </summary>
        [JsonPropertyName("networkSecurityGroup")]
        public SubResource NetworkSecurityGroup { get; set; }

        /// <summary>
        /// The reference to the RouteTable resource.
        /// </summary>
        [JsonPropertyName("routeTable")]
        public SubResource RouteTable { get; set; }

        /// <summary>
        /// Nat gateway associated with this subnet.
        /// </summary>
        [JsonPropertyName("natGateway")]
        public SubResource NatGateway { get; set; }

        /// <summary>
        /// An array of service endpoints.
        /// </summary>
        [JsonPropertyName("serviceEndpoints")]
        public IList<ServiceEndpointPropertiesFormat> ServiceEndpoints { get; set; }

        /// <summary>
        /// An array of service endpoint policies.
        /// </summary>
        [JsonPropertyName("serviceEndpointPolicies")]
        public IList<SubResource> ServiceEndpointPolicies { get; set; }

        /// <summary>
        /// Array of IpAllocation which reference this subnet.
        /// </summary>
        [JsonPropertyName("ipAllocations")]
        public IList<SubResource> IpAllocations { get; set; }

        /// <summary>
        /// An array of references to the delegations on the subnet.
        /// </summary>
        [JsonPropertyName("delegations")]
        public IList<Delegation> Delegations { get; set; }

        /// <summary>
        /// Enable or Disable apply network policies on private end point in the subnet.
        /// </summary>
        [JsonPropertyName("privateEndpointNetworkPolicies")]
        public string PrivateEndpointNetworkPolicies { get; set; }

        /// <summary>
        /// Enable or Disable apply network policies on private link service in the subnet.
        /// </summary>
        [JsonPropertyName("privateLinkServiceNetworkPolicies")]
        public string PrivateLinkServiceNetworkPolicies { get; set; }
    }
}