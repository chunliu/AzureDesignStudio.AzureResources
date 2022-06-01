// Licensed under the MIT License.  See LICENSE in the project root for license information.

using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using AzureDesignStudio.AzureResources.Base;

namespace AzureDesignStudio.AzureResources.Compute
{
    /// <summary>
    /// SSH configuration for Linux based VMs running on Azure
    /// </summary>
    [GeneratedCode("ArmTypeGenerator", "0.1.8.0")]
    public partial class SshConfiguration
    {
        /// <summary>
        /// The list of SSH public keys used to authenticate with linux based VMs.
        /// </summary>
        [JsonPropertyName("publicKeys")]
        public IList<SshPublicKey> PublicKeys { get; set; }
    }
}