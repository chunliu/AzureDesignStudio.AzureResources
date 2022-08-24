// Licensed under the MIT License.  See LICENSE in the project root for license information.

using System;
using System.CodeDom.Compiler;
using System.Text.Json.Serialization;
using AzureDesignStudio.AzureResources.Base;

namespace AzureDesignStudio.AzureResources.Web
{
    /// <summary>
    /// AseV3NetworkingConfiguration resource specific properties
    /// </summary>
    [GeneratedCode("ArmTypeGenerator", "0.1.8.0")]
    public partial class AseV3NetworkingConfigurationProperties
    {
        /// <summary>
        /// Property to enable and disable new private endpoint connection creation on ASE
        /// </summary>
        [JsonPropertyName("allowNewPrivateEndpointConnections")]
        public bool AllowNewPrivateEndpointConnections { get; set; }

        /// <summary>
        /// Property to enable and disable FTP on ASEV3
        /// </summary>
        [JsonPropertyName("ftpEnabled")]
        public bool FtpEnabled { get; set; }

        /// <summary>
        /// Customer provided Inbound IP Address. Only able to be set on Ase create.
        /// </summary>
        [JsonPropertyName("inboundIpAddressOverride")]
        public string InboundIpAddressOverride { get; set; }

        /// <summary>
        /// Property to enable and disable Remote Debug on ASEV3
        /// </summary>
        [JsonPropertyName("remoteDebugEnabled")]
        public bool RemoteDebugEnabled { get; set; }
    }
}