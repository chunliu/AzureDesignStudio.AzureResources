using System;
using System.CodeDom.Compiler;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using AzureDesignStudio.AzureResources.Base;

namespace AzureDesignStudio.AzureResources.Network
{
    /// <summary>
    /// Microsoft.Network/ExpressRoutePorts
    /// </summary>
    [GeneratedCode("Microsoft.Json.Schema.ToDotNet", "1.1.3.0")]
    public partial class ExpressRoutePorts : ResourceBase
    {
        [Required]
        [JsonPropertyName("type")]
        public override string Type => "Microsoft.Network/ExpressRoutePorts";

        [Required]
        [JsonPropertyName("apiVersion")]
        public override string ApiVersion => "2020-11-01";

        /// <summary>
        /// ExpressRoutePort properties.
        /// </summary>
        [Required]
        [JsonPropertyName("properties")]
        public ExpressRoutePortPropertiesFormat Properties { get; set; }

        /// <summary>
        /// The identity of ExpressRoutePort, if configured.
        /// </summary>
        [JsonPropertyName("identity")]
        public ManagedServiceIdentity Identity { get; set; }
    }
}