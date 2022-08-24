// Licensed under the MIT License.  See LICENSE in the project root for license information.

using System;
using System.CodeDom.Compiler;
using System.Text.Json.Serialization;
using AzureDesignStudio.AzureResources.Base;

namespace AzureDesignStudio.AzureResources.Web
{
    /// <summary>
    /// Auth Secrets for Container App Scale Rule
    /// </summary>
    [GeneratedCode("ArmTypeGenerator", "0.1.8.0")]
    public partial class ScaleRuleAuth
    {
        /// <summary>
        /// Name of the Container App secret from which to pull the auth params.
        /// </summary>
        [JsonPropertyName("secretRef")]
        public string SecretRef { get; set; }

        /// <summary>
        /// Trigger Parameter that uses the secret
        /// </summary>
        [JsonPropertyName("triggerParameter")]
        public string TriggerParameter { get; set; }
    }
}