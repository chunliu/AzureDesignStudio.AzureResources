// Licensed under the MIT License.  See LICENSE in the project root for license information.

using System;
using System.CodeDom.Compiler;
using System.Text.Json.Serialization;
using AzureDesignStudio.AzureResources.Base;

namespace AzureDesignStudio.AzureResources.ApiManagement
{
    /// <summary>
    /// Parameters supplied to the Create TagDescription operation.
    /// </summary>
    [GeneratedCode("ArmTypeGenerator", "0.1.8.0")]
    public partial class TagDescriptionBaseProperties
    {
        /// <summary>
        /// Description of the Tag.
        /// </summary>
        [JsonPropertyName("description")]
        public string Description { get; set; }

        /// <summary>
        /// Description of the external resources describing the tag.
        /// </summary>
        [JsonPropertyName("externalDocsDescription")]
        public string ExternalDocsDescription { get; set; }

        /// <summary>
        /// Absolute URL of external resources describing the tag.
        /// </summary>
        [JsonPropertyName("externalDocsUrl")]
        public string ExternalDocsUrl { get; set; }
    }
}