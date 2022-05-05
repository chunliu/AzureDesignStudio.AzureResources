// Licensed under the MIT License.  See LICENSE in the project root for license information.

using System;
using System.CodeDom.Compiler;
using System.Text.Json.Serialization;
using AzureDesignStudio.AzureResources.Base;

namespace AzureDesignStudio.AzureResources.Network
{
    /// <summary>
    /// The Office365 breakout policy.
    /// </summary>
    [GeneratedCode("ArmTypeGenerator", "0.1.8.0")]
    public partial class O365PolicyProperties
    {
        /// <summary>
        /// Office365 breakout categories.
        /// </summary>
        [JsonPropertyName("breakOutCategories")]
        public O365BreakOutCategoryPolicies BreakOutCategories { get; set; }
    }
}