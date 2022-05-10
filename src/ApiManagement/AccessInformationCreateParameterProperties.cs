// Licensed under the MIT License.  See LICENSE in the project root for license information.

using System;
using System.CodeDom.Compiler;
using System.Text.Json.Serialization;
using AzureDesignStudio.AzureResources.Base;

namespace AzureDesignStudio.AzureResources.ApiManagement
{
    /// <summary>
    /// Tenant access information update parameters of the API Management service
    /// </summary>
    [GeneratedCode("ArmTypeGenerator", "0.1.8.0")]
    public partial class AccessInformationCreateParameterProperties
    {
        /// <summary>
        /// Determines whether direct access is enabled.
        /// </summary>
        [JsonPropertyName("enabled")]
        public bool Enabled { get; set; }

        /// <summary>
        /// Primary access key. This property will not be filled on 'GET' operations! Use '/listSecrets' POST request to get the value.
        /// </summary>
        [JsonPropertyName("primaryKey")]
        public string PrimaryKey { get; set; }

        /// <summary>
        /// Principal (User) Identifier.
        /// </summary>
        [JsonPropertyName("principalId")]
        public string PrincipalId { get; set; }

        /// <summary>
        /// Secondary access key. This property will not be filled on 'GET' operations! Use '/listSecrets' POST request to get the value.
        /// </summary>
        [JsonPropertyName("secondaryKey")]
        public string SecondaryKey { get; set; }
    }
}