using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using AzureDesignStudio.AzureResources.Base;

namespace AzureDesignStudio.AzureResources.Storage
{
    /// <summary>
    /// Microsoft.Storage/storageAccounts/queueServices
    /// </summary>
    [GeneratedCode("Microsoft.Json.Schema.ToDotNet", "1.1.3.0")]
    public partial class StorageAccountsQueueServices : ResourceBase
    {
        [Required]
        [JsonPropertyName("apiVersion")]
        public override string ApiVersion => "2021-06-01";

        /// <summary>
        /// The properties of a storage account’s Queue service.
        /// </summary>
        [JsonPropertyName("properties")]
        public QueueServicePropertiesProperties Properties { get; set; }
        [JsonPropertyName("resources")]
        public IList<StorageAccountsQueueServicesQueues> Resources { get; set; }

        [Required]
        [JsonPropertyName("type")]
        public override string Type => "Microsoft.Storage/storageAccounts/queueServices";
    }
}