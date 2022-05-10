// Licensed under the MIT License.  See LICENSE in the project root for license information.

using System;
using System.CodeDom.Compiler;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using AzureDesignStudio.AzureResources.Base;

namespace AzureDesignStudio.AzureResources.ApiManagement
{
    /// <summary>
    /// Parameters supplied to the Create Backend operation.
    /// </summary>
    [GeneratedCode("ArmTypeGenerator", "0.1.8.0")]
    public partial class BackendContractProperties
    {
        /// <summary>
        /// Details of the Credentials used to connect to Backend.
        /// </summary>
        [JsonPropertyName("credentials")]
        public BackendCredentialsContract Credentials { get; set; }

        /// <summary>
        /// Backend Description.
        /// </summary>
        [JsonPropertyName("description")]
        public string Description { get; set; }

        /// <summary>
        /// Properties specific to the Backend Type.
        /// </summary>
        [JsonPropertyName("properties")]
        public BackendProperties Properties { get; set; }

        /// <summary>
        /// Backend communication protocol.
        /// </summary>
        [Required]
        [JsonPropertyName("protocol")]
        public string Protocol { get; set; }

        /// <summary>
        /// Details of the Backend WebProxy Server to use in the Request to Backend.
        /// </summary>
        [JsonPropertyName("proxy")]
        public BackendProxyContract Proxy { get; set; }

        /// <summary>
        /// Management Uri of the Resource in External System. This url can be the Arm Resource Id of Logic Apps, Function Apps or API Apps.
        /// </summary>
        [JsonPropertyName("resourceId")]
        public string ResourceId { get; set; }

        /// <summary>
        /// Backend Title.
        /// </summary>
        [JsonPropertyName("title")]
        public string Title { get; set; }

        /// <summary>
        /// Properties controlling TLS Certificate Validation.
        /// </summary>
        [JsonPropertyName("tls")]
        public BackendTlsProperties Tls { get; set; }

        /// <summary>
        /// Runtime Url of the Backend.
        /// </summary>
        [Required]
        [JsonPropertyName("url")]
        public string Url { get; set; }
    }
}