// Licensed under the MIT License.  See LICENSE in the project root for license information.

using System;
using System.CodeDom.Compiler;
using System.Text.Json.Serialization;
using AzureDesignStudio.AzureResources.Base;

namespace AzureDesignStudio.AzureResources.ApiManagement
{
    /// <summary>
    /// API contact information
    /// </summary>
    [GeneratedCode("ArmTypeGenerator", "0.1.8.0")]
    public partial class ApiContactInformation
    {
        /// <summary>
        /// The email address of the contact person/organization. MUST be in the format of an email address
        /// </summary>
        [JsonPropertyName("email")]
        public string Email { get; set; }

        /// <summary>
        /// The identifying name of the contact person/organization
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; set; }

        /// <summary>
        /// The URL pointing to the contact information. MUST be in the format of a URL
        /// </summary>
        [JsonPropertyName("url")]
        public string Url { get; set; }
    }
}