// Licensed under the MIT License.  See LICENSE in the project root for license information.

using System;
using System.CodeDom.Compiler;
using System.Text.Json.Serialization;
using AzureDesignStudio.AzureResources.Base;

namespace AzureDesignStudio.AzureResources.Web
{
    /// <summary>
    /// The configuration settings of a forward proxy used to make the requests.
    /// </summary>
    [GeneratedCode("ArmTypeGenerator", "0.1.8.0")]
    public partial class ForwardProxy
    {
        /// <summary>
        /// The convention used to determine the url of the request made.
        /// </summary>
        [JsonPropertyName("convention")]
        public string Convention { get; set; }

        /// <summary>
        /// The name of the header containing the host of the request.
        /// </summary>
        [JsonPropertyName("customHostHeaderName")]
        public string CustomHostHeaderName { get; set; }

        /// <summary>
        /// The name of the header containing the scheme of the request.
        /// </summary>
        [JsonPropertyName("customProtoHeaderName")]
        public string CustomProtoHeaderName { get; set; }
    }
}