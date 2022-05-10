// Licensed under the MIT License.  See LICENSE in the project root for license information.

using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using AzureDesignStudio.AzureResources.Base;

namespace AzureDesignStudio.AzureResources.ApiManagement
{
    [GeneratedCode("ArmTypeGenerator", "0.1.8.0")]
    public partial class DataMasking
    {
        /// <summary>
        /// Masking settings for headers
        /// </summary>
        [JsonPropertyName("headers")]
        public IList<DataMaskingEntity> Headers { get; set; }

        /// <summary>
        /// Masking settings for Url query parameters
        /// </summary>
        [JsonPropertyName("queryParams")]
        public IList<DataMaskingEntity> QueryParams { get; set; }
    }
}