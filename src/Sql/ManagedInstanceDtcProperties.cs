// Licensed under the MIT License.  See LICENSE in the project root for license information.

using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using AzureDesignStudio.AzureResources.Base;

namespace AzureDesignStudio.AzureResources.Sql
{
    /// <summary>
    /// The properties of managed instance DTC.
    /// </summary>
    [GeneratedCode("ArmTypeGenerator", "0.1.8.0")]
    public partial class ManagedInstanceDtcProperties
    {
        /// <summary>
        /// Active status of managed instance DTC.
        /// </summary>
        [JsonPropertyName("dtcEnabled")]
        public bool DtcEnabled { get; set; }

        /// <summary>
        /// External dns suffix search list of managed instance DTC.
        /// </summary>
        [JsonPropertyName("externalDnsSuffixSearchList")]
        public IList<string> ExternalDnsSuffixSearchList { get; set; }

        /// <summary>
        /// The Security Settings of managed instance DTC.
        /// </summary>
        [JsonPropertyName("securitySettings")]
        public ManagedInstanceDtcSecuritySettings SecuritySettings { get; set; }
    }
}