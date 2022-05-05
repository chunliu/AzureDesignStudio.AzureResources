// Licensed under the MIT License.  See LICENSE in the project root for license information.

using System;
using System.CodeDom.Compiler;
using System.Text.Json.Serialization;
using AzureDesignStudio.AzureResources.Base;

namespace AzureDesignStudio.AzureResources.Network
{
    /// <summary>
    /// Contains the IpTag associated with the object.
    /// </summary>
    [GeneratedCode("ArmTypeGenerator", "0.1.8.0")]
    public partial class IpTag
    {
        /// <summary>
        /// The IP tag type. Example: FirstPartyUsage.
        /// </summary>
        [JsonPropertyName("ipTagType")]
        public string IpTagType { get; set; }

        /// <summary>
        /// The value of the IP tag associated with the public IP. Example: SQL.
        /// </summary>
        [JsonPropertyName("tag")]
        public string Tag { get; set; }
    }
}