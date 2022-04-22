using System;
using System.CodeDom.Compiler;
using System.Text.Json.Serialization;
using AzureDesignStudio.AzureResources.Base;

namespace AzureDesignStudio.AzureResources.Network
{
    /// <summary>
    /// VirtualHubRouteTableV2 Resource.
    /// </summary>
    [GeneratedCode("Microsoft.Json.Schema.ToDotNet", "1.1.3.0")]
    public partial class VirtualHubRouteTableV2
    {
        /// <summary>
        /// Properties of the virtual hub route table v2.
        /// </summary>
        [JsonPropertyName("properties")]
        public VirtualHubRouteTableV2Properties Properties { get; set; }

        /// <summary>
        /// The name of the resource that is unique within a resource group. This name can be used to access the resource.
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; set; }
    }
}