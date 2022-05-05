// Licensed under the MIT License.  See LICENSE in the project root for license information.

using System;
using System.CodeDom.Compiler;
using System.Text.Json.Serialization;
using AzureDesignStudio.AzureResources.Base;

namespace AzureDesignStudio.AzureResources.Web
{
    /// <summary>
    /// Directory for virtual application.
    /// </summary>
    [GeneratedCode("ArmTypeGenerator", "0.1.8.0")]
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