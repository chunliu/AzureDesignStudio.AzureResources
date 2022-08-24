// Licensed under the MIT License.  See LICENSE in the project root for license information.

using System;
using System.CodeDom.Compiler;
using System.Text.Json.Serialization;
using AzureDesignStudio.AzureResources.Base;

namespace AzureDesignStudio.AzureResources.Storage
{
    /// <summary>
    /// Object to define the base blob action conditions. Properties daysAfterModificationGreaterThan, daysAfterLastAccessTimeGreaterThan and daysAfterCreationGreaterThan are mutually exclusive. The daysAfterLastTierChangeGreaterThan property is only applicable for tierToArchive actions which requires daysAfterModificationGreaterThan to be set, also it cannot be used in conjunction with daysAfterLastAccessTimeGreaterThan or daysAfterCreationGreaterThan.
    /// </summary>
    [GeneratedCode("ArmTypeGenerator", "0.1.8.0")]
    public partial class DateAfterModification
    {
        /// <summary>
        /// Value indicating the age in days after blob creation.
        /// </summary>
        [JsonPropertyName("daysAfterCreationGreaterThan")]
        public double DaysAfterCreationGreaterThan { get; set; }

        /// <summary>
        /// Value indicating the age in days after last blob access. This property can only be used in conjunction with last access time tracking policy
        /// </summary>
        [JsonPropertyName("daysAfterLastAccessTimeGreaterThan")]
        public double DaysAfterLastAccessTimeGreaterThan { get; set; }

        /// <summary>
        /// Value indicating the age in days after last blob tier change time. This property is only applicable for tierToArchive actions and requires daysAfterModificationGreaterThan to be set for baseBlobs based actions. The blob will be archived if both the conditions are satisfied.
        /// </summary>
        [JsonPropertyName("daysAfterLastTierChangeGreaterThan")]
        public double DaysAfterLastTierChangeGreaterThan { get; set; }

        /// <summary>
        /// Value indicating the age in days after last modification
        /// </summary>
        [JsonPropertyName("daysAfterModificationGreaterThan")]
        public double DaysAfterModificationGreaterThan { get; set; }
    }
}