// Licensed under the MIT License.  See LICENSE in the project root for license information.

using System;
using System.CodeDom.Compiler;
using System.Text.Json.Serialization;
using AzureDesignStudio.AzureResources.Base;

namespace AzureDesignStudio.AzureResources.Sql
{
    /// <summary>
    /// Contains the ARM resources for which to create private endpoint connection.
    /// </summary>
    [GeneratedCode("ArmTypeGenerator", "0.1.8.0")]
    public partial class NetworkIsolationSettings
    {
        /// <summary>
        /// The resource id for the SQL server which is the target of this request. If set, private endpoint connection will be created for the SQL server. Must match server which is target of the operation.
        /// </summary>
        [JsonPropertyName("sqlServerResourceId")]
        public string SqlServerResourceId { get; set; }

        /// <summary>
        /// The resource id for the storage account used to store BACPAC file. If set, private endpoint connection will be created for the storage account. Must match storage account used for StorageUri parameter.
        /// </summary>
        [JsonPropertyName("storageAccountResourceId")]
        public string StorageAccountResourceId { get; set; }
    }
}