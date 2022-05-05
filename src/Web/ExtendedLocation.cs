// Licensed under the MIT License.  See LICENSE in the project root for license information.

using System;
using System.CodeDom.Compiler;
using System.Text.Json.Serialization;
using AzureDesignStudio.AzureResources.Base;

namespace AzureDesignStudio.AzureResources.Web
{
    /// <summary>
    /// Extended Location.
    /// </summary>
    [GeneratedCode("ArmTypeGenerator", "0.1.8.0")]
    public partial class ExtendedLocation
    {
        /// <summary>
        /// Name of extended location.
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; set; }
    }
}