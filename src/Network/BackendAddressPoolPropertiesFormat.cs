using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using AzureDesignStudio.AzureResources.Base;

namespace AzureDesignStudio.AzureResources.Network
{
    /// <summary>
    /// Properties of the backend address pool.
    /// </summary>
    [GeneratedCode("Microsoft.Json.Schema.ToDotNet", "1.1.3.0")]
    public partial class BackendAddressPoolPropertiesFormat
    {
        /// <summary>
        /// The location of the backend address pool.
        /// </summary>
        [JsonPropertyName("location")]
        public string Location { get; set; }

        /// <summary>
        /// An array of backend addresses.
        /// </summary>
        [JsonPropertyName("loadBalancerBackendAddresses")]
        public IList<LoadBalancerBackendAddress> LoadBalancerBackendAddresses { get; set; }
    }
}