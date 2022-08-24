// Licensed under the MIT License.  See LICENSE in the project root for license information.

using System;
using System.CodeDom.Compiler;
using System.Text.Json.Serialization;
using AzureDesignStudio.AzureResources.Base;

namespace AzureDesignStudio.AzureResources.Sql
{
    /// <summary>
    /// The Transaction Manager Communication Settings of managed instance DTC.
    /// </summary>
    [GeneratedCode("ArmTypeGenerator", "0.1.8.0")]
    public partial class ManagedInstanceDtcTransactionManagerCommunicationSettings
    {
        /// <summary>
        /// Allow Inbound traffic to managed instance DTC.
        /// </summary>
        [JsonPropertyName("allowInboundEnabled")]
        public bool AllowInboundEnabled { get; set; }

        /// <summary>
        /// Allow Outbound traffic of managed instance DTC.
        /// </summary>
        [JsonPropertyName("allowOutboundEnabled")]
        public bool AllowOutboundEnabled { get; set; }

        /// <summary>
        /// Authentication type of managed instance DTC.
        /// </summary>
        [JsonPropertyName("authentication")]
        public string Authentication { get; set; }
    }
}