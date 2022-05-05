// Licensed under the MIT License.  See LICENSE in the project root for license information.

using System;
using System.CodeDom.Compiler;
using System.Text.Json.Serialization;
using AzureDesignStudio.AzureResources.Base;

namespace AzureDesignStudio.AzureResources.Network
{
    /// <summary>
    /// SKU of nat gateway.
    /// </summary>
    [GeneratedCode("ArmTypeGenerator", "0.1.8.0")]
    public partial class NatGatewaySku
    {
        /// <summary>
        /// Name of Nat Gateway SKU.
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; set; }
    }
}