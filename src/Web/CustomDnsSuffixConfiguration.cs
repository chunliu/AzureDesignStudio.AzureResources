// Licensed under the MIT License.  See LICENSE in the project root for license information.

using System;
using System.CodeDom.Compiler;
using System.Text.Json.Serialization;
using AzureDesignStudio.AzureResources.Base;

namespace AzureDesignStudio.AzureResources.Web
{
    /// <summary>
    /// Full view of the custom domain suffix configuration for ASEv3.
    /// </summary>
    [GeneratedCode("ArmTypeGenerator", "0.1.8.0")]
    public partial class CustomDnsSuffixConfiguration
    {
        /// <summary>
        /// Kind of resource.
        /// </summary>
        [JsonPropertyName("kind")]
        public string Kind { get; set; }

        /// <summary>
        /// CustomDnsSuffixConfiguration resource specific properties
        /// </summary>
        [JsonPropertyName("properties")]
        public CustomDnsSuffixConfigurationProperties Properties { get; set; }
    }
}