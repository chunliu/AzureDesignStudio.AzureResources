// Licensed under the MIT License.  See LICENSE in the project root for license information.

using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using AzureDesignStudio.AzureResources.Base;

namespace AzureDesignStudio.AzureResources.Web
{
    /// <summary>
    /// The configuration settings of the Azure Active Directory allowed principals.
    /// </summary>
    [GeneratedCode("ArmTypeGenerator", "0.1.8.0")]
    public partial class AllowedPrincipals
    {
        /// <summary>
        /// The list of the allowed groups.
        /// </summary>
        [JsonPropertyName("groups")]
        public IList<string> Groups { get; set; }

        /// <summary>
        /// The list of the allowed identities.
        /// </summary>
        [JsonPropertyName("identities")]
        public IList<string> Identities { get; set; }
    }
}