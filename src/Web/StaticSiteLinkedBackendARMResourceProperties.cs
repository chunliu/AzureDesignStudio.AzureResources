// Licensed under the MIT License.  See LICENSE in the project root for license information.

using System;
using System.CodeDom.Compiler;
using System.Text.Json.Serialization;
using AzureDesignStudio.AzureResources.Base;

namespace AzureDesignStudio.AzureResources.Web
{
    /// <summary>
    /// StaticSiteLinkedBackendARMResource resource specific properties
    /// </summary>
    [GeneratedCode("ArmTypeGenerator", "0.1.8.0")]
    public partial class StaticSiteLinkedBackendARMResourceProperties
    {
        /// <summary>
        /// The resource id of the backend linked to the static site
        /// </summary>
        [JsonPropertyName("backendResourceId")]
        public string BackendResourceId { get; set; }

        /// <summary>
        /// The region of the backend linked to the static site
        /// </summary>
        [JsonPropertyName("region")]
        public string Region { get; set; }
    }
}