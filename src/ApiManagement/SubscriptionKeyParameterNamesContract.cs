// Licensed under the MIT License.  See LICENSE in the project root for license information.

using System;
using System.CodeDom.Compiler;
using System.Text.Json.Serialization;
using AzureDesignStudio.AzureResources.Base;

namespace AzureDesignStudio.AzureResources.ApiManagement
{
    /// <summary>
    /// Subscription key parameter names details.
    /// </summary>
    [GeneratedCode("ArmTypeGenerator", "0.1.8.0")]
    public partial class SubscriptionKeyParameterNamesContract
    {
        /// <summary>
        /// Subscription key header name.
        /// </summary>
        [JsonPropertyName("header")]
        public string Header { get; set; }

        /// <summary>
        /// Subscription key query string parameter name.
        /// </summary>
        [JsonPropertyName("query")]
        public string Query { get; set; }
    }
}