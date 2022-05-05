// Licensed under the MIT License.  See LICENSE in the project root for license information.

using System;
using System.CodeDom.Compiler;
using System.Text.Json.Serialization;
using AzureDesignStudio.AzureResources.Base;

namespace AzureDesignStudio.AzureResources.Web
{
    /// <summary>
    /// Specification for an App Service Environment to use for this resource.
    /// </summary>
    [GeneratedCode("ArmTypeGenerator", "0.1.8.0")]
    public partial class HostingEnvironmentProfile
    {
        /// <summary>
        /// Resource ID of the App Service Environment.
        /// </summary>
        [JsonPropertyName("id")]
        public string Id { get; set; }
    }
}