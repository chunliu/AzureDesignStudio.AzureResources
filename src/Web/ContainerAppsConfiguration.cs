// Licensed under the MIT License.  See LICENSE in the project root for license information.

using System;
using System.CodeDom.Compiler;
using System.Text.Json.Serialization;
using AzureDesignStudio.AzureResources.Base;

namespace AzureDesignStudio.AzureResources.Web
{
    [GeneratedCode("ArmTypeGenerator", "0.1.8.0")]
    public partial class ContainerAppsConfiguration
    {
        /// <summary>
        /// Resource ID of a subnet for control plane infrastructure components. This subnet must be in the same VNET as the subnet defined in appSubnetResourceId. Must not overlap with the IP range defined in platformReservedCidr, if defined.
        /// </summary>
        [JsonPropertyName("appSubnetResourceId")]
        public string AppSubnetResourceId { get; set; }

        /// <summary>
        /// Resource ID of a subnet for control plane infrastructure components. This subnet must be in the same VNET as the subnet defined in appSubnetResourceId. Must not overlap with the IP range defined in platformReservedCidr, if defined.
        /// </summary>
        [JsonPropertyName("controlPlaneSubnetResourceId")]
        public string ControlPlaneSubnetResourceId { get; set; }

        /// <summary>
        /// Azure Monitor instrumentation key used by Dapr to export Service to Service communication telemetry
        /// </summary>
        [JsonPropertyName("daprAIInstrumentationKey")]
        public string DaprAIInstrumentationKey { get; set; }

        /// <summary>
        /// CIDR notation IP range assigned to the Docker bridge network. It must not overlap with any Subnet IP ranges or the IP range defined in platformReservedCidr, if defined.
        /// </summary>
        [JsonPropertyName("dockerBridgeCidr")]
        public string DockerBridgeCidr { get; set; }

        /// <summary>
        /// IP range in CIDR notation that can be reserved for environment infrastructure IP addresses. It must not overlap with any other Subnet IP ranges.
        /// </summary>
        [JsonPropertyName("platformReservedCidr")]
        public string PlatformReservedCidr { get; set; }

        /// <summary>
        /// An IP address from the IP range defined by platformReservedCidr that will be reserved for the internal DNS server
        /// </summary>
        [JsonPropertyName("platformReservedDnsIP")]
        public string PlatformReservedDnsIP { get; set; }
    }
}