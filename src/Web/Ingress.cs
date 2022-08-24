// Licensed under the MIT License.  See LICENSE in the project root for license information.

using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using AzureDesignStudio.AzureResources.Base;

namespace AzureDesignStudio.AzureResources.Web
{
    /// <summary>
    /// Container App Ingress configuration.
    /// </summary>
    [GeneratedCode("ArmTypeGenerator", "0.1.8.0")]
    public partial class Ingress
    {
        /// <summary>
        /// Bool indicating if HTTP connections to is allowed. If set to false HTTP connections are automatically redirected to HTTPS connections
        /// </summary>
        [JsonPropertyName("allowInsecure")]
        public bool AllowInsecure { get; set; }

        /// <summary>
        /// Bool indicating if app exposes an external http endpoint
        /// </summary>
        [JsonPropertyName("external")]
        public bool External { get; set; }

        /// <summary>
        /// Target Port in containers for traffic from ingress
        /// </summary>
        [JsonPropertyName("targetPort")]
        public int TargetPort { get; set; }
        [JsonPropertyName("traffic")]
        public IList<TrafficWeight> Traffic { get; set; }

        /// <summary>
        /// Ingress transport protocol.
        /// </summary>
        [JsonPropertyName("transport")]
        public string Transport { get; set; }
    }
}