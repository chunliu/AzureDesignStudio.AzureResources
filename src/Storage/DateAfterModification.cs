// Licensed under the MIT License.  See LICENSE in the project root for license information.

using System;
using System.CodeDom.Compiler;
using System.Text.Json.Serialization;
using AzureDesignStudio.AzureResources.Base;

namespace AzureDesignStudio.AzureResources.Storage
{
    /// <summary>
    /// Object to define the number of days after object last modification Or last access. Properties daysAfterModificationGreaterThan and daysAfterLastAccessTimeGreaterThan are mutually exclusive.
    /// </summary>
    [GeneratedCode("ArmTypeGenerator", "0.1.8.0")]
    public partial class DateAfterModification
    {
        /// <summary>
        /// Value indicating the age in days after last blob access. This property can only be used in conjunction with last access time tracking policy
        /// </summary>
        [JsonPropertyName("daysAfterLastAccessTimeGreaterThan")]
        public double DaysAfterLastAccessTimeGreaterThan { get; set; }

        /// <summary>
        /// Value indicating the age in days after last modification
        /// </summary>
        [JsonPropertyName("daysAfterModificationGreaterThan")]
        public double DaysAfterModificationGreaterThan { get; set; }
    }
}