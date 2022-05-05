// Licensed under the MIT License.  See LICENSE in the project root for license information.

using System;
using System.CodeDom.Compiler;
using System.Text.Json.Serialization;
using AzureDesignStudio.AzureResources.Base;

namespace AzureDesignStudio.AzureResources.Storage
{
    /// <summary>
    /// Management policy action for base blob.
    /// </summary>
    [GeneratedCode("ArmTypeGenerator", "0.1.8.0")]
    public partial class ManagementPolicyBaseBlob
    {
        /// <summary>
        /// Object to define the number of days after object last modification Or last access. Properties daysAfterModificationGreaterThan and daysAfterLastAccessTimeGreaterThan are mutually exclusive.
        /// </summary>
        [JsonPropertyName("delete")]
        public DateAfterModification Delete { get; set; }

        /// <summary>
        /// This property enables auto tiering of a blob from cool to hot on a blob access. This property requires tierToCool.daysAfterLastAccessTimeGreaterThan.
        /// </summary>
        [JsonPropertyName("enableAutoTierToHotFromCool")]
        public bool EnableAutoTierToHotFromCool { get; set; }

        /// <summary>
        /// Object to define the number of days after object last modification Or last access. Properties daysAfterModificationGreaterThan and daysAfterLastAccessTimeGreaterThan are mutually exclusive.
        /// </summary>
        [JsonPropertyName("tierToArchive")]
        public DateAfterModification TierToArchive { get; set; }

        /// <summary>
        /// Object to define the number of days after object last modification Or last access. Properties daysAfterModificationGreaterThan and daysAfterLastAccessTimeGreaterThan are mutually exclusive.
        /// </summary>
        [JsonPropertyName("tierToCool")]
        public DateAfterModification TierToCool { get; set; }
    }
}