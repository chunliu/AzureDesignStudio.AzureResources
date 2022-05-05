// Licensed under the MIT License.  See LICENSE in the project root for license information.

using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using AzureDesignStudio.AzureResources.Base;

namespace AzureDesignStudio.AzureResources.Network
{
    /// <summary>
    /// Properties of ExpressRouteCircuit.
    /// </summary>
    [GeneratedCode("ArmTypeGenerator", "0.1.8.0")]
    public partial class ExpressRouteCircuitPropertiesFormat
    {
        /// <summary>
        /// Allow classic operations.
        /// </summary>
        [JsonPropertyName("allowClassicOperations")]
        public bool AllowClassicOperations { get; set; }

        /// <summary>
        /// The list of authorizations.
        /// </summary>
        [JsonPropertyName("authorizations")]
        public IList<ExpressRouteCircuitAuthorization> Authorizations { get; set; }

        /// <summary>
        /// The list of peerings.
        /// </summary>
        [JsonPropertyName("peerings")]
        public IList<ExpressRouteCircuitPeering> Peerings { get; set; }

        /// <summary>
        /// The ServiceProviderNotes.
        /// </summary>
        [JsonPropertyName("serviceProviderNotes")]
        public string ServiceProviderNotes { get; set; }

        /// <summary>
        /// The ServiceProviderProperties.
        /// </summary>
        [JsonPropertyName("serviceProviderProperties")]
        public ExpressRouteCircuitServiceProviderProperties ServiceProviderProperties { get; set; }

        /// <summary>
        /// The reference to the ExpressRoutePort resource when the circuit is provisioned on an ExpressRoutePort resource.
        /// </summary>
        [JsonPropertyName("expressRoutePort")]
        public SubResource ExpressRoutePort { get; set; }

        /// <summary>
        /// The bandwidth of the circuit when the circuit is provisioned on an ExpressRoutePort resource.
        /// </summary>
        [JsonPropertyName("bandwidthInGbps")]
        public double BandwidthInGbps { get; set; }

        /// <summary>
        /// The GatewayManager Etag.
        /// </summary>
        [JsonPropertyName("gatewayManagerEtag")]
        public string GatewayManagerEtag { get; set; }
    }
}