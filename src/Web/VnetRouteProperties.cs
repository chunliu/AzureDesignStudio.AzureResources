using System;
using System.CodeDom.Compiler;
using System.Text.Json.Serialization;
using AzureDesignStudio.AzureResources.Base;

namespace AzureDesignStudio.AzureResources.Web
{
    /// <summary>
    /// VnetRoute resource specific properties
    /// </summary>
    [GeneratedCode("Microsoft.Json.Schema.ToDotNet", "1.1.3.0")]
    public partial class VnetRouteProperties
    {
        /// <summary>
        /// The ending address for this route. If the start address is specified in CIDR notation, this must be omitted.
        /// </summary>
        [JsonPropertyName("endAddress")]
        public string EndAddress { get; set; }

        /// <summary>
        /// The type of route this is:
        [JsonPropertyName("routeType")]
        public string RouteType { get; set; }

        /// <summary>
        /// The starting address for this route. This may also include a CIDR notation, in which case the end address must not be specified.
        /// </summary>
        [JsonPropertyName("startAddress")]
        public string StartAddress { get; set; }
    }
}