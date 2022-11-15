// Licensed under the MIT License.  See LICENSE in the project root for license information.

using System.CodeDom.Compiler;
using System.Text.Json.Serialization;

namespace AzureDesignStudio.AzureResources.Network
{
    /// <summary>
    /// NatGatewaySku
    /// </summary>
    [GeneratedCode("ArmTypeGenerator", "0.1.3.54561")]
    public partial class NatGatewaySku
    {
        /// <summary>
        /// Name of Nat Gateway SKU.
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; set; }
    }
}