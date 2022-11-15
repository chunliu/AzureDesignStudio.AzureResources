// Licensed under the MIT License.  See LICENSE in the project root for license information.

using System.CodeDom.Compiler;
using System.Text.Json.Serialization;

namespace AzureDesignStudio.AzureResources.Network
{
    /// <summary>
    /// DhcpOptions
    /// </summary>
    [GeneratedCode("ArmTypeGenerator", "0.1.3.54561")]
    public partial class DhcpOptions
    {
        /// <summary>
        /// The list of DNS servers IP addresses.
        /// </summary>
        [JsonPropertyName("dnsServers")]
        public IList<string> DnsServers { get; set; }
    }
}