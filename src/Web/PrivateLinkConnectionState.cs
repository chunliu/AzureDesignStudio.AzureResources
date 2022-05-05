// Licensed under the MIT License.  See LICENSE in the project root for license information.

using System;
using System.CodeDom.Compiler;
using System.Text.Json.Serialization;
using AzureDesignStudio.AzureResources.Base;

namespace AzureDesignStudio.AzureResources.Web
{
    /// <summary>
    /// The state of a private link connection
    /// </summary>
    [GeneratedCode("ArmTypeGenerator", "0.1.8.0")]
    public partial class PrivateLinkConnectionState
    {
        /// <summary>
        /// ActionsRequired for a private link connection
        /// </summary>
        [JsonPropertyName("actionsRequired")]
        public string ActionsRequired { get; set; }

        /// <summary>
        /// Description of a private link connection
        /// </summary>
        [JsonPropertyName("description")]
        public string Description { get; set; }

        /// <summary>
        /// Status of a private link connection
        /// </summary>
        [JsonPropertyName("status")]
        public string Status { get; set; }
    }
}