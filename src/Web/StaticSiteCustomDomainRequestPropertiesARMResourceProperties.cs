using System;
using System.CodeDom.Compiler;
using System.Text.Json.Serialization;
using AzureDesignStudio.AzureResources.Base;

namespace AzureDesignStudio.AzureResources.Web
{
    /// <summary>
    /// StaticSiteCustomDomainRequestPropertiesARMResource resource specific properties
    /// </summary>
    [GeneratedCode("Microsoft.Json.Schema.ToDotNet", "1.1.3.0")]
    public partial class StaticSiteCustomDomainRequestPropertiesARMResourceProperties
    {
        /// <summary>
        /// Validation method for adding a custom domain
        /// </summary>
        [JsonPropertyName("validationMethod")]
        public string ValidationMethod { get; set; }
    }
}