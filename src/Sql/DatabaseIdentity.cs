// Licensed under the MIT License.  See LICENSE in the project root for license information.

using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using AzureDesignStudio.AzureResources.Base;

namespace AzureDesignStudio.AzureResources.Sql
{
    /// <summary>
    /// Azure Active Directory identity configuration for a resource.
    /// </summary>
    [GeneratedCode("ArmTypeGenerator", "0.1.8.0")]
    public partial class DatabaseIdentity
    {
        /// <summary>
        /// The identity type.
        /// </summary>
        [JsonPropertyName("type")]
        public string Type { get; set; }

        /// <summary>
        /// The resource ids of the user assigned identities to use
        /// </summary>
        [JsonPropertyName("userAssignedIdentities")]
        public IDictionary<string, object> UserAssignedIdentities { get; set; }
    }
}