using System;
using System.CodeDom.Compiler;
using System.Text.Json.Serialization;
using AzureDesignStudio.AzureResources.Base;

namespace AzureDesignStudio.AzureResources.Web
{
    /// <summary>
    /// Azure Files or Blob Storage access information value for dictionary storage.
    /// </summary>
    [GeneratedCode("Microsoft.Json.Schema.ToDotNet", "1.1.3.0")]
    public partial class AzureStorageInfoValue
    {
        /// <summary>
        /// Access key for the storage account.
        /// </summary>
        [JsonPropertyName("accessKey")]
        public string AccessKey { get; set; }

        /// <summary>
        /// Name of the storage account.
        /// </summary>
        [JsonPropertyName("accountName")]
        public string AccountName { get; set; }

        /// <summary>
        /// Path to mount the storage within the site's runtime environment.
        /// </summary>
        [JsonPropertyName("mountPath")]
        public string MountPath { get; set; }

        /// <summary>
        /// Name of the file share (container name, for Blob storage).
        /// </summary>
        [JsonPropertyName("shareName")]
        public string ShareName { get; set; }

        /// <summary>
        /// Type of storage.
        /// </summary>
        [JsonPropertyName("type")]
        public string Type { get; set; }
    }
}