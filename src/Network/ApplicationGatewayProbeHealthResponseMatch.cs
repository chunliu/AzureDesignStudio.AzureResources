using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using AzureDesignStudio.AzureResources.Base;

namespace AzureDesignStudio.AzureResources.Network
{
    /// <summary>
    /// Application gateway probe health response match.
    /// </summary>
    [GeneratedCode("Microsoft.Json.Schema.ToDotNet", "1.1.3.0")]
    public partial class ApplicationGatewayProbeHealthResponseMatch
    {
        /// <summary>
        /// Body that must be contained in the health response. Default value is empty.
        /// </summary>
        [JsonPropertyName("body")]
        public string Body { get; set; }

        /// <summary>
        /// Allowed ranges of healthy status codes. Default range of healthy status codes is 200-399.
        /// </summary>
        [JsonPropertyName("statusCodes")]
        public IList<string> StatusCodes { get; set; }
    }
}