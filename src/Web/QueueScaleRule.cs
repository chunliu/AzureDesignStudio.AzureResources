// Licensed under the MIT License.  See LICENSE in the project root for license information.

using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using AzureDesignStudio.AzureResources.Base;

namespace AzureDesignStudio.AzureResources.Web
{
    /// <summary>
    /// Container App container Azure Queue based scaling rule.
    /// </summary>
    [GeneratedCode("ArmTypeGenerator", "0.1.8.0")]
    public partial class QueueScaleRule
    {
        /// <summary>
        /// Authentication secrets for the queue scale rule.
        /// </summary>
        [JsonPropertyName("auth")]
        public IList<ScaleRuleAuth> Auth { get; set; }

        /// <summary>
        /// Queue length.
        /// </summary>
        [JsonPropertyName("queueLength")]
        public int QueueLength { get; set; }

        /// <summary>
        /// Queue name.
        /// </summary>
        [JsonPropertyName("queueName")]
        public string QueueName { get; set; }
    }
}