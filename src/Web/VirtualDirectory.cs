using System;
using System.CodeDom.Compiler;
using System.Text.Json.Serialization;
using AzureDesignStudio.AzureResources.Base;

namespace AzureDesignStudio.AzureResources.Web
{
    /// <summary>
    /// Directory for virtual application.
    /// </summary>
    [GeneratedCode("Microsoft.Json.Schema.ToDotNet", "1.1.3.0")]
    public partial class VirtualDirectory
    {
        /// <summary>
        /// Physical path.
        /// </summary>
        [JsonPropertyName("physicalPath")]
        public string PhysicalPath { get; set; }

        /// <summary>
        /// Path to virtual application.
        /// </summary>
        [JsonPropertyName("virtualPath")]
        public string VirtualPath { get; set; }
    }
}