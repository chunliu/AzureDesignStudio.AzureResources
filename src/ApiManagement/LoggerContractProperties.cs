// Licensed under the MIT License.  See LICENSE in the project root for license information.

using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using AzureDesignStudio.AzureResources.Base;

namespace AzureDesignStudio.AzureResources.ApiManagement
{
    /// <summary>
    /// The Logger entity in API Management represents an event sink that you can use to log API Management events. Currently the Logger entity supports logging API Management events to Azure Event Hubs.
    /// </summary>
    [GeneratedCode("ArmTypeGenerator", "0.1.8.0")]
    public partial class LoggerContractProperties
    {
        /// <summary>
        /// The name and SendRule connection string of the event hub for azureEventHub logger.
        [JsonPropertyName("credentials")]
        public IDictionary<string, string> Credentials { get; set; }

        /// <summary>
        /// Logger description.
        /// </summary>
        [JsonPropertyName("description")]
        public string Description { get; set; }

        /// <summary>
        /// Whether records are buffered in the logger before publishing. Default is assumed to be true.
        /// </summary>
        [JsonPropertyName("isBuffered")]
        public bool IsBuffered { get; set; }

        /// <summary>
        /// Logger type.
        /// </summary>
        [Required]
        [JsonPropertyName("loggerType")]
        public string LoggerType { get; set; }

        /// <summary>
        /// Azure Resource Id of a log target (either Azure Event Hub resource or Azure Application Insights resource).
        /// </summary>
        [JsonPropertyName("resourceId")]
        public string ResourceId { get; set; }
    }
}