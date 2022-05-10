// Licensed under the MIT License.  See LICENSE in the project root for license information.

using System;
using System.CodeDom.Compiler;
using System.Text.Json.Serialization;
using AzureDesignStudio.AzureResources.Base;

namespace AzureDesignStudio.AzureResources.ApiManagement
{
    /// <summary>
    /// API license information
    /// </summary>
    [GeneratedCode("ArmTypeGenerator", "0.1.8.0")]
    public partial class ApiLicenseInformation
    {
        /// <summary>
        /// The license name used for the API
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; set; }

        /// <summary>
        /// A URL to the license used for the API. MUST be in the format of a URL
        /// </summary>
        [JsonPropertyName("url")]
        public string Url { get; set; }
    }
}