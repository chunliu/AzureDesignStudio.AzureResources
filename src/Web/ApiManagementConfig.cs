// Licensed under the MIT License.  See LICENSE in the project root for license information.

using System;
using System.CodeDom.Compiler;
using System.Text.Json.Serialization;
using AzureDesignStudio.AzureResources.Base;

namespace AzureDesignStudio.AzureResources.Web
{
    /// <summary>
    /// Azure API management (APIM) configuration linked to the app.
    /// </summary>
    [GeneratedCode("ArmTypeGenerator", "0.1.8.0")]
    public partial class ApiManagementConfig
    {
        /// <summary>
        /// APIM-Api Identifier.
        /// </summary>
        [JsonPropertyName("id")]
        public string Id { get; set; }
    }
}