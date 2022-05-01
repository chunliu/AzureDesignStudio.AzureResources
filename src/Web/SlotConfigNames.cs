using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using AzureDesignStudio.AzureResources.Base;

namespace AzureDesignStudio.AzureResources.Web
{
    /// <summary>
    /// Names for connection strings, application settings, and external Azure storage account configuration
    [GeneratedCode("Microsoft.Json.Schema.ToDotNet", "1.1.3.0")]
    public partial class SlotConfigNames
    {
        /// <summary>
        /// List of application settings names.
        /// </summary>
        [JsonPropertyName("appSettingNames")]
        public IList<string> AppSettingNames { get; set; }

        /// <summary>
        /// List of external Azure storage account identifiers.
        /// </summary>
        [JsonPropertyName("azureStorageConfigNames")]
        public IList<string> AzureStorageConfigNames { get; set; }

        /// <summary>
        /// List of connection string names.
        /// </summary>
        [JsonPropertyName("connectionStringNames")]
        public IList<string> ConnectionStringNames { get; set; }
    }
}