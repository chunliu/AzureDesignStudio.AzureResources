// Licensed under the MIT License.  See LICENSE in the project root for license information.

using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using AzureDesignStudio.AzureResources.Base;

namespace AzureDesignStudio.AzureResources.Compute
{
    /// <summary>
    /// Describes the disallowed disk types.
    /// </summary>
    [GeneratedCode("ArmTypeGenerator", "0.1.8.0")]
    public partial class Disallowed
    {
        /// <summary>
        /// A list of disk types.
        /// </summary>
        [JsonPropertyName("diskTypes")]
        public IList<string> DiskTypes { get; set; }
    }
}