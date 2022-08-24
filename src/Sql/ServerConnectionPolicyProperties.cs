// Licensed under the MIT License.  See LICENSE in the project root for license information.

using System;
using System.CodeDom.Compiler;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using AzureDesignStudio.AzureResources.Base;

namespace AzureDesignStudio.AzureResources.Sql
{
    /// <summary>
    /// The properties of a server connection policy.
    /// </summary>
    [GeneratedCode("ArmTypeGenerator", "0.1.8.0")]
    public partial class ServerConnectionPolicyProperties
    {
        /// <summary>
        /// The server connection type.
        /// </summary>
        [Required]
        [JsonPropertyName("connectionType")]
        public string ConnectionType { get; set; }
    }
}