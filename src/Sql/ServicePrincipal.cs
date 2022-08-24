// Licensed under the MIT License.  See LICENSE in the project root for license information.

using System;
using System.CodeDom.Compiler;
using System.Text.Json.Serialization;
using AzureDesignStudio.AzureResources.Base;

namespace AzureDesignStudio.AzureResources.Sql
{
    /// <summary>
    /// The managed instance's service principal configuration for a resource.
    /// </summary>
    [GeneratedCode("ArmTypeGenerator", "0.1.8.0")]
    public partial class ServicePrincipal
    {
        /// <summary>
        /// Service principal type.
        /// </summary>
        [JsonPropertyName("type")]
        public string Type { get; set; }
    }
}