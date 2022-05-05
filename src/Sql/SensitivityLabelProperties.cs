// Licensed under the MIT License.  See LICENSE in the project root for license information.

using System;
using System.CodeDom.Compiler;
using System.Text.Json.Serialization;
using AzureDesignStudio.AzureResources.Base;

namespace AzureDesignStudio.AzureResources.Sql
{
    /// <summary>
    /// Properties of a sensitivity label.
    /// </summary>
    [GeneratedCode("ArmTypeGenerator", "0.1.8.0")]
    public partial class SensitivityLabelProperties
    {
        /// <summary>
        /// The information type.
        /// </summary>
        [JsonPropertyName("informationType")]
        public string InformationType { get; set; }

        /// <summary>
        /// The information type ID.
        /// </summary>
        [JsonPropertyName("informationTypeId")]
        public string InformationTypeId { get; set; }

        /// <summary>
        /// The label ID.
        /// </summary>
        [JsonPropertyName("labelId")]
        public string LabelId { get; set; }

        /// <summary>
        /// The label name.
        /// </summary>
        [JsonPropertyName("labelName")]
        public string LabelName { get; set; }
        [JsonPropertyName("rank")]
        public string Rank { get; set; }
    }
}