// Licensed under the MIT License.  See LICENSE in the project root for license information.

using System.CodeDom.Compiler;
using System.Text.Json.Serialization;

namespace AzureDesignStudio.AzureResources.Network
{
    /// <summary>
    /// Delegation
    /// </summary>
    [GeneratedCode("ArmTypeGenerator", "0.1.3.54561")]
    public partial class Delegation
    {
        /// <summary>
        /// Properties of the subnet.
        /// </summary>
        [JsonPropertyName("properties")]
        public ServiceDelegationPropertiesFormat Properties { get; set; }

        /// <summary>
        /// The name of the resource that is unique within a subnet. This name can be used to access the resource.
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; set; }

        /// <summary>
        /// A unique read-only string that changes whenever the resource is updated.
        /// </summary>
        [JsonIgnore]
        public string Etag { get; private set; }

        /// <summary>
        /// Resource type.
        /// </summary>
        [JsonPropertyName("type")]
        public string Type { get; set; }

        /// <summary>
        /// Resource ID.
        /// </summary>
        [JsonIgnore]
        public string Id { get; private set; }
    }
}