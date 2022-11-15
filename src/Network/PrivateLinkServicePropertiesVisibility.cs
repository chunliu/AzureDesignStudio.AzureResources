// Licensed under the MIT License.  See LICENSE in the project root for license information.

using System.CodeDom.Compiler;
using System.Text.Json.Serialization;

namespace AzureDesignStudio.AzureResources.Network
{
    /// <summary>
    /// PrivateLinkServicePropertiesVisibility
    /// </summary>
    [GeneratedCode("ArmTypeGenerator", "0.1.3.54561")]
    public partial class PrivateLinkServicePropertiesVisibility
    {
        /// <summary>
        /// The list of subscriptions.
        /// </summary>
        [JsonPropertyName("subscriptions")]
        public IList<string> Subscriptions { get; set; }
    }
}