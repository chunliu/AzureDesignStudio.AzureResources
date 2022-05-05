// Licensed under the MIT License.  See LICENSE in the project root for license information.

using System;
using System.CodeDom.Compiler;
using System.Text.Json.Serialization;
using AzureDesignStudio.AzureResources.Base;

namespace AzureDesignStudio.AzureResources.Web
{
    /// <summary>
    /// Actions which to take by the auto-heal module when a rule is triggered.
    /// </summary>
    [GeneratedCode("ArmTypeGenerator", "0.1.8.0")]
    public partial class AutoHealActions
    {
        /// <summary>
        /// Predefined action to be taken.
        /// </summary>
        [JsonPropertyName("actionType")]
        public string ActionType { get; set; }

        /// <summary>
        /// Custom action to be executed
        [JsonPropertyName("customAction")]
        public AutoHealCustomAction CustomAction { get; set; }

        /// <summary>
        /// Minimum time the process must execute
        [JsonPropertyName("minProcessExecutionTime")]
        public string MinProcessExecutionTime { get; set; }
    }
}