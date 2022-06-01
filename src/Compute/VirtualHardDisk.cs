// Licensed under the MIT License.  See LICENSE in the project root for license information.

using System;
using System.CodeDom.Compiler;
using System.Text.Json.Serialization;
using AzureDesignStudio.AzureResources.Base;

namespace AzureDesignStudio.AzureResources.Compute
{
    /// <summary>
    /// Describes the uri of a disk.
    /// </summary>
    [GeneratedCode("ArmTypeGenerator", "0.1.8.0")]
    public partial class VirtualHardDisk
    {
        /// <summary>
        /// Specifies the virtual hard disk's uri.
        /// </summary>
        [JsonPropertyName("uri")]
        public string Uri { get; set; }
    }
}