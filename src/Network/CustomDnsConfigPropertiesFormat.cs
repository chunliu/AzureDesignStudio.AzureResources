// Licensed under the MIT License.  See LICENSE in the project root for license information.

using System.CodeDom.Compiler;
using System.Text.Json.Serialization;

namespace AzureDesignStudio.AzureResources.Network
{
    /// <summary>
    /// CustomDnsConfigPropertiesFormat
    /// </summary>
    [GeneratedCode("ArmTypeGenerator", "0.1.3.54561")]
    public partial class CustomDnsConfigPropertiesFormat
    {
        /// <summary>
        /// Fqdn that resolves to private endpoint ip address.
        /// </summary>
        [JsonPropertyName("fqdn")]
        public string Fqdn { get; set; }

        /// <summary>
        /// A list of private ip addresses of the private endpoint.
        /// </summary>
        [JsonPropertyName("ipAddresses")]
        public IList<string> IpAddresses { get; set; }
    }
}