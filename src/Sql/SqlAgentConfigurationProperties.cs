// Licensed under the MIT License.  See LICENSE in the project root for license information.

using System;
using System.CodeDom.Compiler;
using System.Text.Json.Serialization;
using AzureDesignStudio.AzureResources.Base;

namespace AzureDesignStudio.AzureResources.Sql
{
    /// <summary>
    /// Sql agent configuration properties.
    /// </summary>
    [GeneratedCode("ArmTypeGenerator", "0.1.8.0")]
    public partial class SqlAgentConfigurationProperties
    {
        /// <summary>
        /// The state of Sql Agent.
        /// </summary>
        [JsonPropertyName("state")]
        public string State { get; set; }
    }
}