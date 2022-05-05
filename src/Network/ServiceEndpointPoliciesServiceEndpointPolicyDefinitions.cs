// Licensed under the MIT License.  See LICENSE in the project root for license information.

using System;
using System.CodeDom.Compiler;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using AzureDesignStudio.AzureResources.Base;

namespace AzureDesignStudio.AzureResources.Network
{
    /// <summary>
    /// Microsoft.Network/serviceEndpointPolicies/serviceEndpointPolicyDefinitions
    /// </summary>
    [GeneratedCode("ArmTypeGenerator", "0.1.8.0")]
    public partial class ServiceEndpointPoliciesServiceEndpointPolicyDefinitions : ResourceBase
    {
        [Required]
        [JsonPropertyName("type")]
        public override string Type => "Microsoft.Network/serviceEndpointPolicies/serviceEndpointPolicyDefinitions";

        [Required]
        [JsonPropertyName("apiVersion")]
        public override string ApiVersion => "2020-11-01";

        /// <summary>
        /// Properties of the service endpoint policy definition.
        /// </summary>
        [Required]
        [JsonPropertyName("properties")]
        public ServiceEndpointPolicyDefinitionPropertiesFormat Properties { get; set; }
    }
}