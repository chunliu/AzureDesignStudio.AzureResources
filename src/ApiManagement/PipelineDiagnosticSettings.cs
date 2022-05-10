// Licensed under the MIT License.  See LICENSE in the project root for license information.

using System;
using System.CodeDom.Compiler;
using System.Text.Json.Serialization;
using AzureDesignStudio.AzureResources.Base;

namespace AzureDesignStudio.AzureResources.ApiManagement
{
    /// <summary>
    /// Diagnostic settings for incoming/outgoing HTTP messages to the Gateway.
    /// </summary>
    [GeneratedCode("ArmTypeGenerator", "0.1.8.0")]
    public partial class PipelineDiagnosticSettings
    {
        /// <summary>
        /// Http message diagnostic settings.
        /// </summary>
        [JsonPropertyName("request")]
        public HttpMessageDiagnostic Request { get; set; }

        /// <summary>
        /// Http message diagnostic settings.
        /// </summary>
        [JsonPropertyName("response")]
        public HttpMessageDiagnostic Response { get; set; }
    }
}