using System;
using System.CodeDom.Compiler;
using System.Text.Json.Serialization;
using AzureDesignStudio.AzureResources.Base;

namespace AzureDesignStudio.AzureResources.Web
{
    /// <summary>
    /// Extended Location.
    /// </summary>
    [GeneratedCode("Microsoft.Json.Schema.ToDotNet", "1.1.3.0")]
    public partial class ExtendedLocation
    {
        /// <summary>
        /// Name of extended location.
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; set; }
    }
}