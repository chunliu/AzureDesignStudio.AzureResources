// Licensed under the MIT License.  See LICENSE in the project root for license information.

using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using AzureDesignStudio.AzureResources.Base;

namespace AzureDesignStudio.AzureResources.ApiManagement
{
    /// <summary>
    /// Operation Contract Properties
    /// </summary>
    [GeneratedCode("ArmTypeGenerator", "0.1.8.0")]
    public partial class OperationContractProperties
    {
        /// <summary>
        /// Description of the operation. May include HTML formatting tags.
        /// </summary>
        [JsonPropertyName("description")]
        public string Description { get; set; }

        /// <summary>
        /// Operation Name.
        /// </summary>
        [Required]
        [JsonPropertyName("displayName")]
        public string DisplayName { get; set; }

        /// <summary>
        /// A Valid HTTP Operation Method. Typical Http Methods like GET, PUT, POST but not limited by only them.
        /// </summary>
        [Required]
        [JsonPropertyName("method")]
        public string Method { get; set; }

        /// <summary>
        /// Operation Policies
        /// </summary>
        [JsonPropertyName("policies")]
        public string Policies { get; set; }

        /// <summary>
        /// Operation request details.
        /// </summary>
        [JsonPropertyName("request")]
        public RequestContract Request { get; set; }

        /// <summary>
        /// Array of Operation responses.
        /// </summary>
        [JsonPropertyName("responses")]
        public IList<ResponseContract> Responses { get; set; }

        /// <summary>
        /// Collection of URL template parameters.
        /// </summary>
        [JsonPropertyName("templateParameters")]
        public IList<ParameterContract> TemplateParameters { get; set; }

        /// <summary>
        /// Relative URL template identifying the target resource for this operation. May include parameters. Example: /customers/{cid}/orders/{oid}/?date={date}
        /// </summary>
        [Required]
        [JsonPropertyName("urlTemplate")]
        public string UrlTemplate { get; set; }
    }
}