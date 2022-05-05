// Licensed under the MIT License.  See LICENSE in the project root for license information.

using System;
using System.CodeDom.Compiler;
using System.Text.Json.Serialization;
using AzureDesignStudio.AzureResources.Base;

namespace AzureDesignStudio.AzureResources.Network
{
    /// <summary>
    /// Customer error of an application gateway.
    /// </summary>
    [GeneratedCode("ArmTypeGenerator", "0.1.8.0")]
    public partial class ApplicationGatewayCustomError
    {
        /// <summary>
        /// Status code of the application gateway customer error.
        /// </summary>
        [JsonPropertyName("statusCode")]
        public string StatusCode { get; set; }

        /// <summary>
        /// Error page URL of the application gateway customer error.
        /// </summary>
        [JsonPropertyName("customErrorPageUrl")]
        public string CustomErrorPageUrl { get; set; }
    }
}