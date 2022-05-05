// Licensed under the MIT License.  See LICENSE in the project root for license information.

using System;
using System.CodeDom.Compiler;
using System.Text.Json.Serialization;
using AzureDesignStudio.AzureResources.Base;

namespace AzureDesignStudio.AzureResources.Network
{
    /// <summary>
    /// Network Virtual Appliance Sku Properties.
    /// </summary>
    [GeneratedCode("ArmTypeGenerator", "0.1.8.0")]
    public partial class BreakOutCategoryPolicies
    {
        /// <summary>
        /// Flag to control breakout of o365 allow category.
        /// </summary>
        [JsonPropertyName("allow")]
        public bool Allow { get; set; }

        /// <summary>
        /// Flag to control breakout of o365 optimize category.
        /// </summary>
        [JsonPropertyName("optimize")]
        public bool Optimize { get; set; }

        /// <summary>
        /// Flag to control breakout of o365 default category.
        /// </summary>
        [JsonPropertyName("default")]
        public bool Default { get; set; }
    }
}