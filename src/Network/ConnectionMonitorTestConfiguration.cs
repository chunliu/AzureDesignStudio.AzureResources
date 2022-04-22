using System;
using System.CodeDom.Compiler;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using AzureDesignStudio.AzureResources.Base;

namespace AzureDesignStudio.AzureResources.Network
{
    /// <summary>
    /// Describes a connection monitor test configuration.
    /// </summary>
    [GeneratedCode("Microsoft.Json.Schema.ToDotNet", "1.1.3.0")]
    public partial class ConnectionMonitorTestConfiguration
    {
        /// <summary>
        /// The name of the connection monitor test configuration.
        /// </summary>
        [Required]
        [JsonPropertyName("name")]
        public string Name { get; set; }

        /// <summary>
        /// The frequency of test evaluation, in seconds.
        /// </summary>
        [JsonPropertyName("testFrequencySec")]
        public int TestFrequencySec { get; set; }

        /// <summary>
        /// The protocol to use in test evaluation.
        /// </summary>
        [Required]
        [JsonPropertyName("protocol")]
        public string Protocol { get; set; }

        /// <summary>
        /// The preferred IP version to use in test evaluation. The connection monitor may choose to use a different version depending on other parameters.
        /// </summary>
        [JsonPropertyName("preferredIPVersion")]
        public string PreferredIPVersion { get; set; }

        /// <summary>
        /// The parameters used to perform test evaluation over HTTP.
        /// </summary>
        [JsonPropertyName("httpConfiguration")]
        public ConnectionMonitorHttpConfiguration HttpConfiguration { get; set; }

        /// <summary>
        /// The parameters used to perform test evaluation over TCP.
        /// </summary>
        [JsonPropertyName("tcpConfiguration")]
        public ConnectionMonitorTcpConfiguration TcpConfiguration { get; set; }

        /// <summary>
        /// The parameters used to perform test evaluation over ICMP.
        /// </summary>
        [JsonPropertyName("icmpConfiguration")]
        public ConnectionMonitorIcmpConfiguration IcmpConfiguration { get; set; }

        /// <summary>
        /// The threshold for declaring a test successful.
        /// </summary>
        [JsonPropertyName("successThreshold")]
        public ConnectionMonitorSuccessThreshold SuccessThreshold { get; set; }
    }
}