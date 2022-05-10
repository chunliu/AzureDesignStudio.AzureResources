// Licensed under the MIT License.  See LICENSE in the project root for license information.

using System;
using System.CodeDom.Compiler;
using System.Text.Json.Serialization;
using AzureDesignStudio.AzureResources.Base;

namespace AzureDesignStudio.AzureResources.ApiManagement
{
    /// <summary>
    /// Configuration of a virtual network to which API Management service is deployed.
    /// </summary>
    [GeneratedCode("ArmTypeGenerator", "0.1.8.0")]
    public partial class VirtualNetworkConfiguration
    {
        /// <summary>
        /// The full resource ID of a subnet in a virtual network to deploy the API Management service in.
        /// </summary>
        [JsonPropertyName("subnetResourceId")]
        public string SubnetResourceId { get; set; }
    }
}