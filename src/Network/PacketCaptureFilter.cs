// Licensed under the MIT License.  See LICENSE in the project root for license information.

using System;
using System.CodeDom.Compiler;
using System.Text.Json.Serialization;
using AzureDesignStudio.AzureResources.Base;

namespace AzureDesignStudio.AzureResources.Network
{
    /// <summary>
    /// Filter that is applied to packet capture request. Multiple filters can be applied.
    /// </summary>
    [GeneratedCode("ArmTypeGenerator", "0.1.8.0")]
    public partial class PacketCaptureFilter
    {
        /// <summary>
        /// Protocol to be filtered on.
        /// </summary>
        [JsonPropertyName("protocol")]
        public string Protocol { get; set; }

        /// <summary>
        /// Local IP Address to be filtered on. Notation: "127.0.0.1" for single address entry. "127.0.0.1-127.0.0.255" for range. "127.0.0.1;127.0.0.5"? for multiple entries. Multiple ranges not currently supported. Mixing ranges with multiple entries not currently supported. Default = null.
        /// </summary>
        [JsonPropertyName("localIPAddress")]
        public string LocalIPAddress { get; set; }

        /// <summary>
        /// Local IP Address to be filtered on. Notation: "127.0.0.1" for single address entry. "127.0.0.1-127.0.0.255" for range. "127.0.0.1;127.0.0.5;" for multiple entries. Multiple ranges not currently supported. Mixing ranges with multiple entries not currently supported. Default = null.
        /// </summary>
        [JsonPropertyName("remoteIPAddress")]
        public string RemoteIPAddress { get; set; }

        /// <summary>
        /// Local port to be filtered on. Notation: "80" for single port entry."80-85" for range. "80;443;" for multiple entries. Multiple ranges not currently supported. Mixing ranges with multiple entries not currently supported. Default = null.
        /// </summary>
        [JsonPropertyName("localPort")]
        public string LocalPort { get; set; }

        /// <summary>
        /// Remote port to be filtered on. Notation: "80" for single port entry."80-85" for range. "80;443;" for multiple entries. Multiple ranges not currently supported. Mixing ranges with multiple entries not currently supported. Default = null.
        /// </summary>
        [JsonPropertyName("remotePort")]
        public string RemotePort { get; set; }
    }
}