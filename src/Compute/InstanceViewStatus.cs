// Licensed under the MIT License.  See LICENSE in the project root for license information.

using System;
using System.CodeDom.Compiler;
using System.Text.Json.Serialization;
using AzureDesignStudio.AzureResources.Base;

namespace AzureDesignStudio.AzureResources.Compute
{
    /// <summary>
    /// Instance view status.
    /// </summary>
    [GeneratedCode("ArmTypeGenerator", "0.1.8.0")]
    public partial class InstanceViewStatus
    {
        /// <summary>
        /// The status code.
        /// </summary>
        [JsonPropertyName("code")]
        public string Code { get; set; }

        /// <summary>
        /// The short localizable label for the status.
        /// </summary>
        [JsonPropertyName("displayStatus")]
        public string DisplayStatus { get; set; }

        /// <summary>
        /// The level code.
        /// </summary>
        [JsonPropertyName("level")]
        public string Level { get; set; }

        /// <summary>
        /// The detailed status message, including for alerts and error messages.
        /// </summary>
        [JsonPropertyName("message")]
        public string Message { get; set; }

        /// <summary>
        /// The time of the status.
        /// </summary>
        [JsonPropertyName("time")]
        public DateTime Time { get; set; }
    }
}