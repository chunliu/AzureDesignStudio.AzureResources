// Licensed under the MIT License.  See LICENSE in the project root for license information.

using System;
using System.CodeDom.Compiler;
using System.Text.Json.Serialization;
using AzureDesignStudio.AzureResources.Base;

namespace AzureDesignStudio.AzureResources.ApiManagement
{
    /// <summary>
    /// Control Plane Apis version constraint for the API Management service.
    /// </summary>
    [GeneratedCode("ArmTypeGenerator", "0.1.8.0")]
    public partial class ApiVersionConstraint
    {
        /// <summary>
        /// Limit control plane API calls to API Management service with version equal to or newer than this value.
        /// </summary>
        [JsonPropertyName("minApiVersion")]
        public string MinApiVersion { get; set; }
    }
}