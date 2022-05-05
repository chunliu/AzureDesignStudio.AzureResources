// Licensed under the MIT License.  See LICENSE in the project root for license information.

using System;
using System.CodeDom.Compiler;
using System.Text.Json.Serialization;
using AzureDesignStudio.AzureResources.Base;

namespace AzureDesignStudio.AzureResources.Network
{
    /// <summary>
    /// UrlPathMaps give a url path to the backend mapping information for PathBasedRouting.
    /// </summary>
    [GeneratedCode("ArmTypeGenerator", "0.1.8.0")]
    public partial class ApplicationGatewayUrlPathMap
    {
        /// <summary>
        /// Properties of the application gateway URL path map.
        /// </summary>
        [JsonPropertyName("properties")]
        public ApplicationGatewayUrlPathMapPropertiesFormat Properties { get; set; }

        /// <summary>
        /// Name of the URL path map that is unique within an Application Gateway.
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; set; }
    }
}