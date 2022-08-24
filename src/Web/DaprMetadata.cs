// Licensed under the MIT License.  See LICENSE in the project root for license information.

using System;
using System.CodeDom.Compiler;
using System.Text.Json.Serialization;
using AzureDesignStudio.AzureResources.Base;

namespace AzureDesignStudio.AzureResources.Web
{
    /// <summary>
    /// Container App Dapr component metadata.
    /// </summary>
    [GeneratedCode("ArmTypeGenerator", "0.1.8.0")]
    public partial class DaprMetadata
    {
        /// <summary>
        /// Metadata property name.
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; set; }

        /// <summary>
        /// Name of the Container App secret from which to pull the metadata property value.
        /// </summary>
        [JsonPropertyName("secretRef")]
        public string SecretRef { get; set; }

        /// <summary>
        /// Metadata property value.
        /// </summary>
        [JsonPropertyName("value")]
        public string Value { get; set; }
    }
}