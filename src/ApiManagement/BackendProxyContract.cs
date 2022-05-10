// Licensed under the MIT License.  See LICENSE in the project root for license information.

using System;
using System.CodeDom.Compiler;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using AzureDesignStudio.AzureResources.Base;

namespace AzureDesignStudio.AzureResources.ApiManagement
{
    /// <summary>
    /// Details of the Backend WebProxy Server to use in the Request to Backend.
    /// </summary>
    [GeneratedCode("ArmTypeGenerator", "0.1.8.0")]
    public partial class BackendProxyContract
    {
        /// <summary>
        /// Password to connect to the WebProxy Server
        /// </summary>
        [JsonPropertyName("password")]
        public string Password { get; set; }

        /// <summary>
        /// WebProxy Server AbsoluteUri property which includes the entire URI stored in the Uri instance, including all fragments and query strings.
        /// </summary>
        [Required]
        [JsonPropertyName("url")]
        public string Url { get; set; }

        /// <summary>
        /// Username to connect to the WebProxy server
        /// </summary>
        [JsonPropertyName("username")]
        public string Username { get; set; }
    }
}