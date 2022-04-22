using System;
using System.CodeDom.Compiler;
using System.Text.Json.Serialization;
using AzureDesignStudio.AzureResources.Base;

namespace AzureDesignStudio.AzureResources.Network
{
    /// <summary>
    /// Properties of a service delegation.
    /// </summary>
    [GeneratedCode("Microsoft.Json.Schema.ToDotNet", "1.1.3.0")]
    public partial class ServiceDelegationPropertiesFormat
    {
        /// <summary>
        /// The name of the service to whom the subnet should be delegated (e.g. Microsoft.Sql/servers).
        /// </summary>
        [JsonPropertyName("serviceName")]
        public string ServiceName { get; set; }
    }
}