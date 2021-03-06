// Licensed under the MIT License.  See LICENSE in the project root for license information.

using System;
using System.CodeDom.Compiler;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using AzureDesignStudio.AzureResources.Base;

namespace AzureDesignStudio.AzureResources.Network
{
    /// <summary>
    /// Pool of backend IP addresses.
    /// </summary>
    [GeneratedCode("ArmTypeGenerator", "0.1.8.0")]
    public partial class BackendAddressPool
    {
        /// <summary>
        /// Properties of load balancer backend address pool.
        /// </summary>
        [JsonPropertyName("properties")]
        public BackendAddressPoolPropertiesFormat Properties { get; set; }

        /// <summary>
        /// The name of the resource that is unique within the set of backend address pools used by the load balancer. This name can be used to access the resource.
        /// </summary>
        [Required]
        [JsonPropertyName("name")]
        public string Name { get; set; }
    }
}