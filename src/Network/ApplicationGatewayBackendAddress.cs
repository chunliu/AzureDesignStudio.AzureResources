// Licensed under the MIT License.  See LICENSE in the project root for license information.

using System.CodeDom.Compiler;
using System.Text.Json.Serialization;

namespace AzureDesignStudio.AzureResources.Network
{
    /// <summary>
    /// ApplicationGatewayBackendAddress
    /// </summary>
    [GeneratedCode("ArmTypeGenerator", "0.1.3.54561")]
    public partial class ApplicationGatewayBackendAddress
    {
        /// <summary>
        /// Fully qualified domain name (FQDN).
        /// </summary>
        [JsonPropertyName("fqdn")]
        public string Fqdn { get; set; }

        /// <summary>
        /// IP address.
        /// </summary>
        [JsonPropertyName("ipAddress")]
        public string IpAddress { get; set; }
    }
}