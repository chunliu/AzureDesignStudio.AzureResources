// Licensed under the MIT License.  See LICENSE in the project root for license information.

using System;
using System.CodeDom.Compiler;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using AzureDesignStudio.AzureResources.Base;

namespace AzureDesignStudio.AzureResources.Storage
{
    /// <summary>
    /// Object to define snapshot and version action conditions.
    /// </summary>
    [GeneratedCode("ArmTypeGenerator", "0.1.8.0")]
    public partial class DateAfterCreation
    {
        /// <summary>
        /// Value indicating the age in days after creation
        /// </summary>
        [Required]
        [JsonPropertyName("daysAfterCreationGreaterThan")]
        public double DaysAfterCreationGreaterThan { get; set; }

        /// <summary>
        /// Value indicating the age in days after last blob tier change time. This property is only applicable for tierToArchive actions and requires daysAfterCreationGreaterThan to be set for snapshots and blob version based actions. The blob will be archived if both the conditions are satisfied.
        /// </summary>
        [JsonPropertyName("daysAfterLastTierChangeGreaterThan")]
        public double DaysAfterLastTierChangeGreaterThan { get; set; }
    }
}