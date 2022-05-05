// Licensed under the MIT License.  See LICENSE in the project root for license information.

using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using AzureDesignStudio.AzureResources.Base;

namespace AzureDesignStudio.AzureResources.Network
{
    /// <summary>
    /// Route Filter Rule Resource.
    /// </summary>
    [GeneratedCode("ArmTypeGenerator", "0.1.8.0")]
    public partial class RouteFilterRulePropertiesFormat
    {
        /// <summary>
        /// The access type of the rule.
        /// </summary>
        [Required]
        [JsonPropertyName("access")]
        public string Access { get; set; }

        /// <summary>
        /// The rule type of the rule.
        /// </summary>
        [Required]
        [JsonPropertyName("routeFilterRuleType")]
        public string RouteFilterRuleType { get; set; }

        /// <summary>
        /// The collection for bgp community values to filter on. e.g. ['12076:5010','12076:5020'].
        /// </summary>
        [Required]
        [JsonPropertyName("communities")]
        public IList<string> Communities { get; set; }
    }
}