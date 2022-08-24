// Licensed under the MIT License.  See LICENSE in the project root for license information.

using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using AzureDesignStudio.AzureResources.Base;

namespace AzureDesignStudio.AzureResources.Compute
{
    /// <summary>
    /// Describes the properties of the load balancer configuration.
    /// </summary>
    [GeneratedCode("ArmTypeGenerator", "0.1.8.0")]
    public partial class LoadBalancerConfigurationProperties
    {
        /// <summary>
        /// Specifies the frontend IP to be used for the load balancer. Only IPv4 frontend IP address is supported. Each load balancer configuration must have exactly one frontend IP configuration.
        /// </summary>
        [Required]
        [JsonPropertyName("frontendIPConfigurations")]
        public IList<LoadBalancerFrontendIPConfiguration> FrontendIPConfigurations { get; set; }
    }
}