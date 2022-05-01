using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using AzureDesignStudio.AzureResources.Base;

namespace AzureDesignStudio.AzureResources.Web
{
    /// <summary>
    /// Virtual application in an app.
    /// </summary>
    [GeneratedCode("Microsoft.Json.Schema.ToDotNet", "1.1.3.0")]
    public partial class VirtualApplication
    {
        /// <summary>
        /// Physical path.
        /// </summary>
        [JsonPropertyName("physicalPath")]
        public string PhysicalPath { get; set; }

        /// <summary>
        /// <code>true</code> if preloading is enabled; otherwise, <code>false</code>.
        /// </summary>
        [JsonPropertyName("preloadEnabled")]
        public bool PreloadEnabled { get; set; }

        /// <summary>
        /// Virtual directories for virtual application.
        /// </summary>
        [JsonPropertyName("virtualDirectories")]
        public IList<VirtualDirectory> VirtualDirectories { get; set; }

        /// <summary>
        /// Virtual path.
        /// </summary>
        [JsonPropertyName("virtualPath")]
        public string VirtualPath { get; set; }
    }
}