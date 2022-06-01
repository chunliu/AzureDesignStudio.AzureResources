// Licensed under the MIT License.  See LICENSE in the project root for license information.

using System;
using System.CodeDom.Compiler;
using System.Text.Json.Serialization;
using AzureDesignStudio.AzureResources.Base;

namespace AzureDesignStudio.AzureResources.Compute
{
    /// <summary>
    /// Contains information about the soft deletion policy of the gallery.
    /// </summary>
    [GeneratedCode("ArmTypeGenerator", "0.1.8.0")]
    public partial class SoftDeletePolicy
    {
        /// <summary>
        /// Enables soft-deletion for resources in this gallery, allowing them to be recovered within retention time.
        /// </summary>
        [JsonPropertyName("isSoftDeleteEnabled")]
        public bool IsSoftDeleteEnabled { get; set; }
    }
}