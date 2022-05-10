// Licensed under the MIT License.  See LICENSE in the project root for license information.

using System;
using System.CodeDom.Compiler;
using System.Text.Json.Serialization;
using AzureDesignStudio.AzureResources.Base;

namespace AzureDesignStudio.AzureResources.ApiManagement
{
    [GeneratedCode("ArmTypeGenerator", "0.1.8.0")]
    public partial class PortalRevisionContractProperties
    {
        /// <summary>
        /// Portal revision description.
        /// </summary>
        [JsonPropertyName("description")]
        public string Description { get; set; }

        /// <summary>
        /// Indicates if the portal's revision is public.
        /// </summary>
        [JsonPropertyName("isCurrent")]
        public bool IsCurrent { get; set; }
    }
}