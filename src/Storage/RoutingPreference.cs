// Licensed under the MIT License.  See LICENSE in the project root for license information.

using System;
using System.CodeDom.Compiler;
using System.Text.Json.Serialization;
using AzureDesignStudio.AzureResources.Base;

namespace AzureDesignStudio.AzureResources.Storage
{
    /// <summary>
    /// Routing preference defines the type of network, either microsoft or internet routing to be used to deliver the user data, the default option is microsoft routing
    /// </summary>
    [GeneratedCode("ArmTypeGenerator", "0.1.8.0")]
    public partial class RoutingPreference
    {
        /// <summary>
        /// A boolean flag which indicates whether internet routing storage endpoints are to be published
        /// </summary>
        [JsonPropertyName("publishInternetEndpoints")]
        public bool PublishInternetEndpoints { get; set; }

        /// <summary>
        /// A boolean flag which indicates whether microsoft routing storage endpoints are to be published
        /// </summary>
        [JsonPropertyName("publishMicrosoftEndpoints")]
        public bool PublishMicrosoftEndpoints { get; set; }

        /// <summary>
        /// Routing Choice defines the kind of network routing opted by the user.
        /// </summary>
        [JsonPropertyName("routingChoice")]
        public string RoutingChoice { get; set; }
    }
}