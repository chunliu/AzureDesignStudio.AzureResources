using System;
using System.CodeDom.Compiler;
using System.Text.Json.Serialization;
using AzureDesignStudio.AzureResources.Base;

namespace AzureDesignStudio.AzureResources.Web
{
    /// <summary>
    /// Description of a Virtual Network subnet that is useable for private site access.
    /// </summary>
    [GeneratedCode("Microsoft.Json.Schema.ToDotNet", "1.1.3.0")]
    public partial class PrivateAccessSubnet
    {
        /// <summary>
        /// The key (ID) of the subnet.
        /// </summary>
        [JsonPropertyName("key")]
        public int Key { get; set; }

        /// <summary>
        /// The name of the subnet.
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; set; }
    }
}