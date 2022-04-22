using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using AzureDesignStudio.AzureResources.Base;

namespace AzureDesignStudio.AzureResources.Network
{
    /// <summary>
    /// Describes the HTTP configuration.
    /// </summary>
    [GeneratedCode("Microsoft.Json.Schema.ToDotNet", "1.1.3.0")]
    public partial class ConnectionMonitorHttpConfiguration
    {
        /// <summary>
        /// The port to connect to.
        /// </summary>
        [JsonPropertyName("port")]
        public int Port { get; set; }

        /// <summary>
        /// The HTTP method to use.
        /// </summary>
        [JsonPropertyName("method")]
        public string Method { get; set; }

        /// <summary>
        /// The path component of the URI. For instance, "/dir1/dir2".
        /// </summary>
        [JsonPropertyName("path")]
        public string Path { get; set; }

        /// <summary>
        /// The HTTP headers to transmit with the request.
        /// </summary>
        [JsonPropertyName("requestHeaders")]
        public IList<HTTPHeader> RequestHeaders { get; set; }

        /// <summary>
        /// HTTP status codes to consider successful. For instance, "2xx,301-304,418".
        /// </summary>
        [JsonPropertyName("validStatusCodeRanges")]
        public IList<string> ValidStatusCodeRanges { get; set; }

        /// <summary>
        /// Value indicating whether HTTPS is preferred over HTTP in cases where the choice is not explicit.
        /// </summary>
        [JsonPropertyName("preferHTTPS")]
        public bool PreferHTTPS { get; set; }
    }
}