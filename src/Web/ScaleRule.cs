// Licensed under the MIT License.  See LICENSE in the project root for license information.

using System;
using System.CodeDom.Compiler;
using System.Text.Json.Serialization;
using AzureDesignStudio.AzureResources.Base;

namespace AzureDesignStudio.AzureResources.Web
{
    /// <summary>
    /// Container App container scaling rule.
    /// </summary>
    [GeneratedCode("ArmTypeGenerator", "0.1.8.0")]
    public partial class ScaleRule
    {
        /// <summary>
        /// Container App container Azure Queue based scaling rule.
        /// </summary>
        [JsonPropertyName("azureQueue")]
        public QueueScaleRule AzureQueue { get; set; }

        /// <summary>
        /// Container App container Custom scaling rule.
        /// </summary>
        [JsonPropertyName("custom")]
        public CustomScaleRule Custom { get; set; }

        /// <summary>
        /// Container App container Custom scaling rule.
        /// </summary>
        [JsonPropertyName("http")]
        public HttpScaleRule Http { get; set; }

        /// <summary>
        /// Scale Rule Name
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; set; }
    }
}