// Licensed under the MIT License.  See LICENSE in the project root for license information.

using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using AzureDesignStudio.AzureResources.Base;

namespace AzureDesignStudio.AzureResources.Network
{
    /// <summary>
    /// Properties of Backend Address Pool of an application gateway.
    /// </summary>
    [GeneratedCode("ArmTypeGenerator", "0.1.8.0")]
    public partial class ApplicationGatewayBackendAddressPoolPropertiesFormat
    {
        /// <summary>
        /// Backend addresses.
        /// </summary>
        [JsonPropertyName("backendAddresses")]
        public IList<ApplicationGatewayBackendAddress> BackendAddresses { get; set; }
    }
}