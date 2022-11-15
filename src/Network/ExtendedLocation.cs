// Licensed under the MIT License.  See LICENSE in the project root for license information.

using System.CodeDom.Compiler;
using System.Text.Json.Serialization;

namespace AzureDesignStudio.AzureResources.Network
{
    /// <summary>
    /// ExtendedLocation
    /// </summary>
    [GeneratedCode("ArmTypeGenerator", "0.1.3.54561")]
    public partial class ExtendedLocation
    {
        /// <summary>
        /// The name of the extended location.
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; set; }

        /// <summary>
        /// The type of the extended location.
        /// </summary>
        [JsonPropertyName("type")]
        public string Type { get; set; }
    }
}