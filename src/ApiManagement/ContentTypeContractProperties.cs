// Licensed under the MIT License.  See LICENSE in the project root for license information.

using System;
using System.CodeDom.Compiler;
using System.Text.Json.Serialization;
using AzureDesignStudio.AzureResources.Base;

namespace AzureDesignStudio.AzureResources.ApiManagement
{
    [GeneratedCode("ArmTypeGenerator", "0.1.8.0")]
    public partial class ContentTypeContractProperties
    {
        /// <summary>
        /// Content type description.
        /// </summary>
        [JsonPropertyName("description")]
        public string Description { get; set; }

        /// <summary>
        /// Content type identifier
        /// </summary>
        [JsonPropertyName("id")]
        public string Id { get; set; }

        /// <summary>
        /// Content type name. Must be 1 to 250 characters long.
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; set; }

        /// <summary>
        /// Content type schema.
        /// </summary>
        [JsonPropertyName("schema")]
        public object Schema { get; set; }

        /// <summary>
        /// Content type version.
        /// </summary>
        [JsonPropertyName("version")]
        public string Version { get; set; }
    }
}