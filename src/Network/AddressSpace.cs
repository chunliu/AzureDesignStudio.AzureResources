// Licensed under the MIT License.  See LICENSE in the project root for license information.

using System.CodeDom.Compiler;
using System.Text.Json.Serialization;

namespace AzureDesignStudio.AzureResources.Network
{
    /// <summary>
    /// AddressSpace
    /// </summary>
    [GeneratedCode("ArmTypeGenerator", "0.1.3.54561")]
    public partial class AddressSpace
    {
        /// <summary>
        /// A list of address blocks reserved for this virtual network in CIDR notation.
        /// </summary>
        [JsonPropertyName("addressPrefixes")]
        public IList<string> AddressPrefixes { get; set; }
    }
}