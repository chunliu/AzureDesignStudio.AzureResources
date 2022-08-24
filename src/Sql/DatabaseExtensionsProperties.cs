// Licensed under the MIT License.  See LICENSE in the project root for license information.

using System;
using System.CodeDom.Compiler;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using AzureDesignStudio.AzureResources.Base;

namespace AzureDesignStudio.AzureResources.Sql
{
    /// <summary>
    /// Contains the database information after a successful Import, Export, or PolybaseImport
    /// </summary>
    [GeneratedCode("ArmTypeGenerator", "0.1.8.0")]
    public partial class DatabaseExtensionsProperties
    {
        /// <summary>
        /// Administrator login name.
        /// </summary>
        [JsonPropertyName("administratorLogin")]
        public string AdministratorLogin { get; set; }

        /// <summary>
        /// Administrator login password.
        /// </summary>
        [JsonPropertyName("administratorLoginPassword")]
        public string AdministratorLoginPassword { get; set; }

        /// <summary>
        /// Authentication type: SQL authentication or AD password.
        /// </summary>
        [JsonPropertyName("authenticationType")]
        public string AuthenticationType { get; set; }

        /// <summary>
        /// Database edition for the newly created database in the case of an import operation.
        /// </summary>
        [JsonPropertyName("databaseEdition")]
        public string DatabaseEdition { get; set; }

        /// <summary>
        /// Database max size in bytes for the newly created database in the case of an import operation.
        /// </summary>
        [JsonPropertyName("maxSizeBytes")]
        public string MaxSizeBytes { get; set; }

        /// <summary>
        /// Contains the ARM resources for which to create private endpoint connection.
        /// </summary>
        [JsonPropertyName("networkIsolation")]
        public NetworkIsolationSettings NetworkIsolation { get; set; }

        /// <summary>
        /// Operation mode of the operation: Import, Export, or PolybaseImport.
        /// </summary>
        [Required]
        [JsonPropertyName("operationMode")]
        public string OperationMode { get; set; }

        /// <summary>
        /// Database service level objective for the newly created database in the case of an import operation.
        /// </summary>
        [JsonPropertyName("serviceObjectiveName")]
        public string ServiceObjectiveName { get; set; }

        /// <summary>
        /// Storage key for the storage account.
        /// </summary>
        [Required]
        [JsonPropertyName("storageKey")]
        public string StorageKey { get; set; }

        /// <summary>
        /// Storage key type: StorageAccessKey or SharedAccessKey.
        /// </summary>
        [Required]
        [JsonPropertyName("storageKeyType")]
        public string StorageKeyType { get; set; }

        /// <summary>
        /// Storage Uri for the storage account.
        /// </summary>
        [Required]
        [JsonPropertyName("storageUri")]
        public string StorageUri { get; set; }
    }
}