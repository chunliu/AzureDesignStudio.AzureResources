using System;
using System.CodeDom.Compiler;
using System.Text.Json.Serialization;
using AzureDesignStudio.AzureResources.Base;

namespace AzureDesignStudio.AzureResources.Web
{
    /// <summary>
    /// The configuration settings of the token store.
    /// </summary>
    [GeneratedCode("Microsoft.Json.Schema.ToDotNet", "1.1.3.0")]
    public partial class TokenStore
    {
        /// <summary>
        /// The configuration settings of the storage of the tokens if blob storage is used.
        /// </summary>
        [JsonPropertyName("azureBlobStorage")]
        public BlobStorageTokenStore AzureBlobStorage { get; set; }

        /// <summary>
        /// <code>true</code> to durably store platform-specific security tokens that are obtained during login flows; otherwise, <code>false</code>.
        [JsonPropertyName("enabled")]
        public bool Enabled { get; set; }

        /// <summary>
        /// The configuration settings of the storage of the tokens if a file system is used.
        /// </summary>
        [JsonPropertyName("fileSystem")]
        public FileSystemTokenStore FileSystem { get; set; }

        /// <summary>
        /// The number of hours after session token expiration that a session token can be used to
        [JsonPropertyName("tokenRefreshExtensionHours")]
        public double TokenRefreshExtensionHours { get; set; }
    }
}