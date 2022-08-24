// Licensed under the MIT License.  See LICENSE in the project root for license information.

using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using AzureDesignStudio.AzureResources.Base;

namespace AzureDesignStudio.AzureResources.Compute
{
    /// <summary>
    /// The restore point properties.
    /// </summary>
    [GeneratedCode("ArmTypeGenerator", "0.1.8.0")]
    public partial class RestorePointProperties
    {
        /// <summary>
        /// ConsistencyMode of the RestorePoint. Can be specified in the input while creating a restore point. For now, only CrashConsistent is accepted as a valid input. Please refer to https://aka.ms/RestorePoints for more details.
        /// </summary>
        [JsonPropertyName("consistencyMode")]
        public string ConsistencyMode { get; set; }

        /// <summary>
        /// List of disk resource ids that the customer wishes to exclude from the restore point. If no disks are specified, all disks will be included.
        /// </summary>
        [JsonPropertyName("excludeDisks")]
        public IList<ApiEntityReference> ExcludeDisks { get; set; }

        /// <summary>
        /// The API entity reference.
        /// </summary>
        [JsonPropertyName("sourceRestorePoint")]
        public ApiEntityReference SourceRestorePoint { get; set; }

        /// <summary>
        /// Gets the creation time of the restore point.
        /// </summary>
        [JsonPropertyName("timeCreated")]
        public DateTime TimeCreated { get; set; }
    }
}