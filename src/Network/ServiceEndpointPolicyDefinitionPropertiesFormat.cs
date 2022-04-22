using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using AzureDesignStudio.AzureResources.Base;

namespace AzureDesignStudio.AzureResources.Network
{
    /// <summary>
    /// Service Endpoint policy definition resource.
    /// </summary>
    [GeneratedCode("Microsoft.Json.Schema.ToDotNet", "1.1.3.0")]
    public partial class ServiceEndpointPolicyDefinitionPropertiesFormat
    {
        /// <summary>
        /// A description for this rule. Restricted to 140 chars.
        /// </summary>
        [JsonPropertyName("description")]
        public string Description { get; set; }

        /// <summary>
        /// Service endpoint name.
        /// </summary>
        [JsonPropertyName("service")]
        public string Service { get; set; }

        /// <summary>
        /// A list of service resources.
        /// </summary>
        [JsonPropertyName("serviceResources")]
        public IList<string> ServiceResources { get; set; }
    }
}