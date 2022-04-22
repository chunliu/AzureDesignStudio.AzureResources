using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using AzureDesignStudio.AzureResources.Base;

namespace AzureDesignStudio.AzureResources.Network
{
    /// <summary>
    /// Microsoft.Network/serviceEndpointPolicies
    /// </summary>
    [GeneratedCode("Microsoft.Json.Schema.ToDotNet", "1.1.3.0")]
    public partial class ServiceEndpointPolicies : ResourceBase
    {
        [Required]
        [JsonPropertyName("type")]
        public override string Type => "Microsoft.Network/serviceEndpointPolicies";

        [Required]
        [JsonPropertyName("apiVersion")]
        public override string ApiVersion => "2020-11-01";

        /// <summary>
        /// Properties of the service end point policy.
        /// </summary>
        [Required]
        [JsonPropertyName("properties")]
        public ServiceEndpointPolicyPropertiesFormat Properties { get; set; }
        [JsonPropertyName("resources")]
        public IList<ServiceEndpointPolicies_serviceEndpointPolicyDefinitions> Resources { get; set; }
    }
}