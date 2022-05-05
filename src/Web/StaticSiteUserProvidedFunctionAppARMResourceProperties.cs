// Licensed under the MIT License.  See LICENSE in the project root for license information.

using System;
using System.CodeDom.Compiler;
using System.Text.Json.Serialization;
using AzureDesignStudio.AzureResources.Base;

namespace AzureDesignStudio.AzureResources.Web
{
    /// <summary>
    /// StaticSiteUserProvidedFunctionAppARMResource resource specific properties
    /// </summary>
    [GeneratedCode("ArmTypeGenerator", "0.1.8.0")]
    public partial class StaticSiteUserProvidedFunctionAppARMResourceProperties
    {
        /// <summary>
        /// The region of the function app registered with the static site
        /// </summary>
        [JsonPropertyName("functionAppRegion")]
        public string FunctionAppRegion { get; set; }

        /// <summary>
        /// The resource id of the function app registered with the static site
        /// </summary>
        [JsonPropertyName("functionAppResourceId")]
        public string FunctionAppResourceId { get; set; }
    }
}