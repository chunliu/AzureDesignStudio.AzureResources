// Licensed under the MIT License.  See LICENSE in the project root for license information.

using System.CodeDom.Compiler;
using System.Text.Json.Serialization;

namespace AzureDesignStudio.AzureResources.Network
{
    /// <summary>
    /// RouteTable
    /// </summary>
    [GeneratedCode("ArmTypeGenerator", "0.1.3.54561")]
    public partial class RouteTable
    {
        /// <summary>
        /// Properties of the route table.
        /// </summary>
        [JsonPropertyName("properties")]
        public RouteTablePropertiesFormat Properties { get; set; }

        /// <summary>
        /// A unique read-only string that changes whenever the resource is updated.
        /// </summary>
        [JsonIgnore]
        public string Etag { get; private set; }

        /// <summary>
        /// Resource ID.
        /// </summary>
        [JsonIgnore]
        public string Id { get; private set; }

        /// <summary>
        /// Resource name.
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; set; }

        /// <summary>
        /// Resource type.
        /// </summary>
        [JsonPropertyName("type")]
        public string Type { get; set; }

        /// <summary>
        /// Resource location.
        /// </summary>
        [JsonPropertyName("location")]
        public string Location { get; set; }

        /// <summary>
        /// Resource tags.
        /// </summary>
        [JsonPropertyName("tags")]
        public object Tags { get; set; }
    }
}