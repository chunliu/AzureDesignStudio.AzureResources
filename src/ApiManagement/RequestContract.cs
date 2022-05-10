// Licensed under the MIT License.  See LICENSE in the project root for license information.

using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using AzureDesignStudio.AzureResources.Base;

namespace AzureDesignStudio.AzureResources.ApiManagement
{
    /// <summary>
    /// Operation request details.
    /// </summary>
    [GeneratedCode("ArmTypeGenerator", "0.1.8.0")]
    public partial class RequestContract
    {
        /// <summary>
        /// Operation request description.
        /// </summary>
        [JsonPropertyName("description")]
        public string Description { get; set; }

        /// <summary>
        /// Collection of operation request headers.
        /// </summary>
        [JsonPropertyName("headers")]
        public IList<ParameterContract> Headers { get; set; }

        /// <summary>
        /// Collection of operation request query parameters.
        /// </summary>
        [JsonPropertyName("queryParameters")]
        public IList<ParameterContract> QueryParameters { get; set; }

        /// <summary>
        /// Collection of operation request representations.
        /// </summary>
        [JsonPropertyName("representations")]
        public IList<RepresentationContract> Representations { get; set; }
    }
}