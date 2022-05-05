// Licensed under the MIT License.  See LICENSE in the project root for license information.

using System;
using System.CodeDom.Compiler;
using System.Text.Json.Serialization;
using AzureDesignStudio.AzureResources.Base;

namespace AzureDesignStudio.AzureResources.Web
{
    /// <summary>
    /// StaticSiteCustomDomainRequestPropertiesARMResource resource specific properties
    /// </summary>
    [GeneratedCode("ArmTypeGenerator", "0.1.8.0")]
    public partial class StaticSiteCustomDomainRequestPropertiesARMResourceProperties
    {
        /// <summary>
        /// Validation method for adding a custom domain
        /// </summary>
        [JsonPropertyName("validationMethod")]
        public string ValidationMethod { get; set; }
    }
}