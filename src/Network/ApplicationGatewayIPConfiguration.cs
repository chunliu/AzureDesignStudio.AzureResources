// Licensed under the MIT License.  See LICENSE in the project root for license information.

using System.CodeDom.Compiler;
using System.Text.Json.Serialization;

namespace AzureDesignStudio.AzureResources.Network
{
    /// <summary>
    /// ApplicationGatewayIPConfiguration
    /// </summary>
    [GeneratedCode("ArmTypeGenerator", "0.1.3.54561")]
    public partial class ApplicationGatewayIPConfiguration
    {
        /// <summary>
        /// Properties of the application gateway IP configuration.
        /// </summary>
        [JsonPropertyName("properties")]
        public ApplicationGatewayIPConfigurationPropertiesFormat Properties { get; set; }

        /// <summary>
        /// Name of the IP configuration that is unique within an Application Gateway.
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; set; }

        /// <summary>
        /// A unique read-only string that changes whenever the resource is updated.
        /// </summary>
        [JsonIgnore]
        public string Etag { get; private set; }

        /// <summary>
        /// Type of the resource.
        /// </summary>
        [JsonPropertyName("type")]
        public string Type { get; set; }

        /// <summary>
        /// Resource ID.
        /// </summary>
        [JsonIgnore]
        public string Id { get; private set; }
    }
}