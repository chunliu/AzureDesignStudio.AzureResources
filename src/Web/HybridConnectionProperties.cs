using System;
using System.CodeDom.Compiler;
using System.Text.Json.Serialization;
using AzureDesignStudio.AzureResources.Base;

namespace AzureDesignStudio.AzureResources.Web
{
    /// <summary>
    /// HybridConnection resource specific properties
    /// </summary>
    [GeneratedCode("Microsoft.Json.Schema.ToDotNet", "1.1.3.0")]
    public partial class HybridConnectionProperties
    {
        /// <summary>
        /// The hostname of the endpoint.
        /// </summary>
        [JsonPropertyName("hostname")]
        public string Hostname { get; set; }

        /// <summary>
        /// The port of the endpoint.
        /// </summary>
        [JsonPropertyName("port")]
        public int Port { get; set; }

        /// <summary>
        /// The ARM URI to the Service Bus relay.
        /// </summary>
        [JsonPropertyName("relayArmUri")]
        public string RelayArmUri { get; set; }

        /// <summary>
        /// The name of the Service Bus relay.
        /// </summary>
        [JsonPropertyName("relayName")]
        public string RelayName { get; set; }

        /// <summary>
        /// The name of the Service Bus key which has Send permissions. This is used to authenticate to Service Bus.
        /// </summary>
        [JsonPropertyName("sendKeyName")]
        public string SendKeyName { get; set; }

        /// <summary>
        /// The value of the Service Bus key. This is used to authenticate to Service Bus. In ARM this key will not be returned
        [JsonPropertyName("sendKeyValue")]
        public string SendKeyValue { get; set; }

        /// <summary>
        /// The name of the Service Bus namespace.
        /// </summary>
        [JsonPropertyName("serviceBusNamespace")]
        public string ServiceBusNamespace { get; set; }

        /// <summary>
        /// The suffix for the service bus endpoint. By default this is .servicebus.windows.net
        /// </summary>
        [JsonPropertyName("serviceBusSuffix")]
        public string ServiceBusSuffix { get; set; }
    }
}