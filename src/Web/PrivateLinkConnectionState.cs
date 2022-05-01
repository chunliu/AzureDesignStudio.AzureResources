using System;
using System.CodeDom.Compiler;
using System.Text.Json.Serialization;
using AzureDesignStudio.AzureResources.Base;

namespace AzureDesignStudio.AzureResources.Web
{
    /// <summary>
    /// The state of a private link connection
    /// </summary>
    [GeneratedCode("Microsoft.Json.Schema.ToDotNet", "1.1.3.0")]
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