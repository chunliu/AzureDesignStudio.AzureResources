using System;
using System.CodeDom.Compiler;
using System.Text.Json.Serialization;
using AzureDesignStudio.AzureResources.Base;

namespace AzureDesignStudio.AzureResources.Storage
{
    /// <summary>
    /// A list of services that support encryption.
    /// </summary>
    [GeneratedCode("Microsoft.Json.Schema.ToDotNet", "1.1.3.0")]
    public partial class EncryptionServices
    {
        /// <summary>
        /// A service that allows server-side encryption to be used.
        /// </summary>
        [JsonPropertyName("blob")]
        public EncryptionService Blob { get; set; }

        /// <summary>
        /// A service that allows server-side encryption to be used.
        /// </summary>
        [JsonPropertyName("file")]
        public EncryptionService File { get; set; }

        /// <summary>
        /// A service that allows server-side encryption to be used.
        /// </summary>
        [JsonPropertyName("queue")]
        public EncryptionService Queue { get; set; }

        /// <summary>
        /// A service that allows server-side encryption to be used.
        /// </summary>
        [JsonPropertyName("table")]
        public EncryptionService Table { get; set; }
    }
}