using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using AzureDesignStudio.AzureResources.Base;

namespace AzureDesignStudio.AzureResources.Network
{
    /// <summary>
    /// Properties of the load balancer.
    /// </summary>
    [GeneratedCode("Microsoft.Json.Schema.ToDotNet", "1.1.3.0")]
    public partial class LoadBalancerPropertiesFormat
    {
        /// <summary>
        /// Object representing the frontend IPs to be used for the load balancer.
        /// </summary>
        [JsonPropertyName("frontendIPConfigurations")]
        public IList<FrontendIPConfiguration> FrontendIPConfigurations { get; set; }

        /// <summary>
        /// Collection of backend address pools used by a load balancer.
        /// </summary>
        [JsonPropertyName("backendAddressPools")]
        public IList<BackendAddressPool> BackendAddressPools { get; set; }

        /// <summary>
        /// Object collection representing the load balancing rules Gets the provisioning.
        /// </summary>
        [JsonPropertyName("loadBalancingRules")]
        public IList<LoadBalancingRule> LoadBalancingRules { get; set; }

        /// <summary>
        /// Collection of probe objects used in the load balancer.
        /// </summary>
        [JsonPropertyName("probes")]
        public IList<Probe> Probes { get; set; }

        /// <summary>
        /// Collection of inbound NAT Rules used by a load balancer. Defining inbound NAT rules on your load balancer is mutually exclusive with defining an inbound NAT pool. Inbound NAT pools are referenced from virtual machine scale sets. NICs that are associated with individual virtual machines cannot reference an Inbound NAT pool. They have to reference individual inbound NAT rules.
        /// </summary>
        [JsonPropertyName("inboundNatRules")]
        public IList<InboundNatRule> InboundNatRules { get; set; }

        /// <summary>
        /// Defines an external port range for inbound NAT to a single backend port on NICs associated with a load balancer. Inbound NAT rules are created automatically for each NIC associated with the Load Balancer using an external port from this range. Defining an Inbound NAT pool on your Load Balancer is mutually exclusive with defining inbound Nat rules. Inbound NAT pools are referenced from virtual machine scale sets. NICs that are associated with individual virtual machines cannot reference an inbound NAT pool. They have to reference individual inbound NAT rules.
        /// </summary>
        [JsonPropertyName("inboundNatPools")]
        public IList<InboundNatPool> InboundNatPools { get; set; }

        /// <summary>
        /// The outbound rules.
        /// </summary>
        [JsonPropertyName("outboundRules")]
        public IList<OutboundRule> OutboundRules { get; set; }
    }
}