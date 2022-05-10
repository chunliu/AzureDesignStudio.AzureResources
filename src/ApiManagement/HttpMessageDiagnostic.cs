// Licensed under the MIT License.  See LICENSE in the project root for license information.

using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using AzureDesignStudio.AzureResources.Base;

namespace AzureDesignStudio.AzureResources.ApiManagement
{
    /// <summary>
    /// Http message diagnostic settings.
    /// </summary>
    [GeneratedCode("ArmTypeGenerator", "0.1.8.0")]
    public partial class HttpMessageDiagnostic
    {
        /// <summary>
        /// Body logging settings.
        /// </summary>
        [JsonPropertyName("body")]
        public BodyDiagnosticSettings Body { get; set; }
        [JsonPropertyName("dataMasking")]
        public DataMasking DataMasking { get; set; }

        /// <summary>
        /// Array of HTTP Headers to log.
        /// </summary>
        [JsonPropertyName("headers")]
        public IList<string> Headers { get; set; }
    }
}