// Licensed under the MIT License.  See LICENSE in the project root for license information.

using System;
using System.CodeDom.Compiler;
using System.Text.Json.Serialization;
using AzureDesignStudio.AzureResources.Base;

namespace AzureDesignStudio.AzureResources.Sql
{
    /// <summary>
    /// Properties of a long term retention policy
    /// </summary>
    [GeneratedCode("ArmTypeGenerator", "0.1.8.0")]
    public partial class BaseLongTermRetentionPolicyProperties
    {
        /// <summary>
        /// The monthly retention policy for an LTR backup in an ISO 8601 format.
        /// </summary>
        [JsonPropertyName("monthlyRetention")]
        public string MonthlyRetention { get; set; }

        /// <summary>
        /// The weekly retention policy for an LTR backup in an ISO 8601 format.
        /// </summary>
        [JsonPropertyName("weeklyRetention")]
        public string WeeklyRetention { get; set; }

        /// <summary>
        /// The week of year to take the yearly backup in an ISO 8601 format.
        /// </summary>
        [JsonPropertyName("weekOfYear")]
        public int WeekOfYear { get; set; }

        /// <summary>
        /// The yearly retention policy for an LTR backup in an ISO 8601 format.
        /// </summary>
        [JsonPropertyName("yearlyRetention")]
        public string YearlyRetention { get; set; }
    }
}