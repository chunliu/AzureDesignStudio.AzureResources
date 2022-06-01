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
        /// List of disk resource ids that the customer wishes to exclude from the restore point. If no disks are specified, all disks will be included.
        /// </summary>
        [JsonPropertyName("excludeDisks")]
        public IList<ApiEntityReference> ExcludeDisks { get; set; }
    }
}