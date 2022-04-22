using System;
using System.CodeDom.Compiler;
using System.Text.Json.Serialization;
using AzureDesignStudio.AzureResources.Base;

namespace AzureDesignStudio.AzureResources.Network
{
    /// <summary>
    /// ExpressRouteLink child resource definition.
    /// </summary>
    [GeneratedCode("Microsoft.Json.Schema.ToDotNet", "1.1.3.0")]
    public partial class ExpressRouteLink
    {
        /// <summary>
        /// ExpressRouteLink properties.
        /// </summary>
        [JsonPropertyName("properties")]
        public ExpressRouteLinkPropertiesFormat Properties { get; set; }

        /// <summary>
        /// Name of child port resource that is unique among child port resources of the parent.
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; set; }
    }
}