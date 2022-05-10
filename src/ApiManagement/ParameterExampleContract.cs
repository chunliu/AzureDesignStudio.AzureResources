// Licensed under the MIT License.  See LICENSE in the project root for license information.

using System;
using System.CodeDom.Compiler;
using System.Text.Json.Serialization;
using AzureDesignStudio.AzureResources.Base;

namespace AzureDesignStudio.AzureResources.ApiManagement
{
    /// <summary>
    /// Parameter example.
    /// </summary>
    [GeneratedCode("ArmTypeGenerator", "0.1.8.0")]
    public partial class ParameterExampleContract
    {
        /// <summary>
        /// Long description for the example
        /// </summary>
        [JsonPropertyName("description")]
        public string Description { get; set; }

        /// <summary>
        /// A URL that points to the literal example
        /// </summary>
        [JsonPropertyName("externalValue")]
        public string ExternalValue { get; set; }

        /// <summary>
        /// Short description for the example
        /// </summary>
        [JsonPropertyName("summary")]
        public string Summary { get; set; }

        /// <summary>
        /// Example value. May be a primitive value, or an object.
        /// </summary>
        [JsonPropertyName("value")]
        public object Value { get; set; }
    }
}