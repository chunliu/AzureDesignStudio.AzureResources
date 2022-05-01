using System;
using System.CodeDom.Compiler;
using System.Text.Json.Serialization;
using AzureDesignStudio.AzureResources.Base;

namespace AzureDesignStudio.AzureResources.Web
{
    /// <summary>
    /// The configuration settings of the storage of the tokens if blob storage is used.
    /// </summary>
    [GeneratedCode("Microsoft.Json.Schema.ToDotNet", "1.1.3.0")]
    public partial class BlobStorageTokenStore
    {
        /// <summary>
        /// The name of the app setting containing the SAS URL of the blob storage containing the tokens.
        /// </summary>
        [JsonPropertyName("sasUrlSettingName")]
        public string SasUrlSettingName { get; set; }
    }
}