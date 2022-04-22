using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using AzureDesignStudio.AzureResources.Base;

namespace AzureDesignStudio.AzureResources.Network
{
    /// <summary>
    /// Properties of ExpressRouteCrossConnection.
    /// </summary>
    [GeneratedCode("Microsoft.Json.Schema.ToDotNet", "1.1.3.0")]
    public partial class ExpressRouteCrossConnectionProperties
    {
        /// <summary>
        /// The ExpressRouteCircuit.
        /// </summary>
        [JsonPropertyName("expressRouteCircuit")]
        public SubResource ExpressRouteCircuit { get; set; }

        /// <summary>
        /// The provisioning state of the circuit in the connectivity provider system.
        /// </summary>
        [JsonPropertyName("serviceProviderProvisioningState")]
        public string ServiceProviderProvisioningState { get; set; }

        /// <summary>
        /// Additional read only notes set by the connectivity provider.
        /// </summary>
        [JsonPropertyName("serviceProviderNotes")]
        public string ServiceProviderNotes { get; set; }

        /// <summary>
        /// The list of peerings.
        /// </summary>
        [JsonPropertyName("peerings")]
        public IList<ExpressRouteCrossConnectionPeering> Peerings { get; set; }
    }
}