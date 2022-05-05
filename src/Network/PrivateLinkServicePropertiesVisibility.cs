// Licensed under the MIT License.  See LICENSE in the project root for license information.

using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using AzureDesignStudio.AzureResources.Base;

namespace AzureDesignStudio.AzureResources.Network
{
    /// <summary>
    /// The visibility list of the private link service.
    /// </summary>
    [GeneratedCode("ArmTypeGenerator", "0.1.8.0")]
    public partial class PrivateLinkServicePropertiesVisibility
    {
        /// <summary>
        /// The list of subscriptions.
        /// </summary>
        [JsonPropertyName("subscriptions")]
        public IList<string> Subscriptions { get; set; }
    }
}