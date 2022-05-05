// Licensed under the MIT License.  See LICENSE in the project root for license information.

using System;
using System.CodeDom.Compiler;
using System.Text.Json.Serialization;
using AzureDesignStudio.AzureResources.Base;

namespace AzureDesignStudio.AzureResources.Storage
{
    /// <summary>
    /// The properties of File services in storage account.
    /// </summary>
    [GeneratedCode("ArmTypeGenerator", "0.1.8.0")]
    public partial class FileServicePropertiesProperties
    {
        /// <summary>
        /// Sets the CORS rules. You can include up to five CorsRule elements in the request. 
        /// </summary>
        [JsonPropertyName("cors")]
        public CorsRules Cors { get; set; }

        /// <summary>
        /// Protocol settings for file service
        /// </summary>
        [JsonPropertyName("protocolSettings")]
        public ProtocolSettings ProtocolSettings { get; set; }

        /// <summary>
        /// The service properties for soft delete.
        /// </summary>
        [JsonPropertyName("shareDeleteRetentionPolicy")]
        public DeleteRetentionPolicy ShareDeleteRetentionPolicy { get; set; }
    }
}