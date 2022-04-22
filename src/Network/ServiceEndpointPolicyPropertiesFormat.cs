using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using AzureDesignStudio.AzureResources.Base;

namespace AzureDesignStudio.AzureResources.Network
{
    /// <summary>
    /// Service Endpoint Policy resource.
    /// </summary>
    [GeneratedCode("Microsoft.Json.Schema.ToDotNet", "1.1.3.0")]
    public partial class ServiceEndpointPolicyPropertiesFormat
    {
        /// <summary>
        /// A collection of service endpoint policy definitions of the service endpoint policy.
        /// </summary>
        [JsonPropertyName("serviceEndpointPolicyDefinitions")]
        public IList<ServiceEndpointPolicyDefinition> ServiceEndpointPolicyDefinitions { get; set; }
    }
}