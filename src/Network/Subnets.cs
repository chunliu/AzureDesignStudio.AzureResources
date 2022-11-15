// Licensed under the MIT License.  See LICENSE in the project root for license information.

using System.CodeDom.Compiler;
using System.Text.Json.Serialization;
using AzureDesignStudio.AzureResources.Base;

namespace AzureDesignStudio.AzureResources.Network
{
    /// <summary>
    /// Microsoft.Network/virtualNetworks/subnets
    /// </summary>
    [AzureResource("Microsoft.Network/virtualNetworks/subnets", "2022-05-01")]
    [GeneratedCode("ArmTypeGenerator", "0.1.3.54561")]
    public partial class Subnets : ResourceBase
    {
        /// <summary>
        /// The resource id
        /// </summary>
        [JsonIgnore]
        public string Id { get; private set; }

        /// <summary>
        /// The resource type
        /// </summary>
        [JsonPropertyName("type")]
        public override string Type => "Microsoft.Network/virtualNetworks/subnets";

        /// <summary>
        /// The resource api version
        /// </summary>
        [JsonPropertyName("apiVersion")]
        public override string ApiVersion => "2022-05-01";

        /// <summary>
        /// Properties of the subnet.
        /// </summary>
        [JsonPropertyName("properties")]
        public SubnetPropertiesFormat Properties { get; set; }

        /// <summary>
        /// A unique read-only string that changes whenever the resource is updated.
        /// </summary>
        [JsonIgnore]
        public string Etag { get; private set; }
    }
}