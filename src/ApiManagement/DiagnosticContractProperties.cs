// Licensed under the MIT License.  See LICENSE in the project root for license information.

using System;
using System.CodeDom.Compiler;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using AzureDesignStudio.AzureResources.Base;

namespace AzureDesignStudio.AzureResources.ApiManagement
{
    /// <summary>
    /// Diagnostic Entity Properties
    /// </summary>
    [GeneratedCode("ArmTypeGenerator", "0.1.8.0")]
    public partial class DiagnosticContractProperties
    {
        /// <summary>
        /// Specifies for what type of messages sampling settings should not apply.
        /// </summary>
        [JsonPropertyName("alwaysLog")]
        public string AlwaysLog { get; set; }

        /// <summary>
        /// Diagnostic settings for incoming/outgoing HTTP messages to the Gateway.
        /// </summary>
        [JsonPropertyName("backend")]
        public PipelineDiagnosticSettings Backend { get; set; }

        /// <summary>
        /// Diagnostic settings for incoming/outgoing HTTP messages to the Gateway.
        /// </summary>
        [JsonPropertyName("frontend")]
        public PipelineDiagnosticSettings Frontend { get; set; }

        /// <summary>
        /// Sets correlation protocol to use for Application Insights diagnostics.
        /// </summary>
        [JsonPropertyName("httpCorrelationProtocol")]
        public string HttpCorrelationProtocol { get; set; }

        /// <summary>
        /// Log the ClientIP. Default is false.
        /// </summary>
        [JsonPropertyName("logClientIp")]
        public bool LogClientIp { get; set; }

        /// <summary>
        /// Resource Id of a target logger.
        /// </summary>
        [Required]
        [JsonPropertyName("loggerId")]
        public string LoggerId { get; set; }

        /// <summary>
        /// The format of the Operation Name for Application Insights telemetries. Default is Name.
        /// </summary>
        [JsonPropertyName("operationNameFormat")]
        public string OperationNameFormat { get; set; }

        /// <summary>
        /// Sampling settings for Diagnostic.
        /// </summary>
        [JsonPropertyName("sampling")]
        public SamplingSettings Sampling { get; set; }

        /// <summary>
        /// The verbosity level applied to traces emitted by trace policies.
        /// </summary>
        [JsonPropertyName("verbosity")]
        public string Verbosity { get; set; }
    }
}