using System;
using System.CodeDom.Compiler;
using System.Text.Json.Serialization;
using AzureDesignStudio.AzureResources.Base;

namespace AzureDesignStudio.AzureResources.Sql
{
    /// <summary>
    /// The managed database's properties.
    /// </summary>
    [GeneratedCode("Microsoft.Json.Schema.ToDotNet", "1.1.3.0")]
    public partial class ManagedDatabaseProperties
    {
        /// <summary>
        /// Whether to auto complete restore of this managed database.
        /// </summary>
        [JsonPropertyName("autoCompleteRestore")]
        public bool AutoCompleteRestore { get; set; }

        /// <summary>
        /// Collation of the metadata catalog.
        /// </summary>
        [JsonPropertyName("catalogCollation")]
        public string CatalogCollation { get; set; }

        /// <summary>
        /// Collation of the managed database.
        /// </summary>
        [JsonPropertyName("collation")]
        public string Collation { get; set; }

        /// <summary>
        /// Managed database create mode. PointInTimeRestore: Create a database by restoring a point in time backup of an existing database. SourceDatabaseName, SourceManagedInstanceName and PointInTime must be specified. RestoreExternalBackup: Create a database by restoring from external backup files. Collation, StorageContainerUri and StorageContainerSasToken must be specified. Recovery: Creates a database by restoring a geo-replicated backup. RecoverableDatabaseId must be specified as the recoverable database resource ID to restore. RestoreLongTermRetentionBackup: Create a database by restoring from a long term retention backup (longTermRetentionBackupResourceId required).
        /// </summary>
        [JsonPropertyName("createMode")]
        public string CreateMode { get; set; }

        /// <summary>
        /// Last backup file name for restore of this managed database.
        /// </summary>
        [JsonPropertyName("lastBackupName")]
        public string LastBackupName { get; set; }

        /// <summary>
        /// The name of the Long Term Retention backup to be used for restore of this managed database.
        /// </summary>
        [JsonPropertyName("longTermRetentionBackupResourceId")]
        public string LongTermRetentionBackupResourceId { get; set; }

        /// <summary>
        /// The resource identifier of the recoverable database associated with create operation of this database.
        /// </summary>
        [JsonPropertyName("recoverableDatabaseId")]
        public string RecoverableDatabaseId { get; set; }

        /// <summary>
        /// The restorable dropped database resource id to restore when creating this database.
        /// </summary>
        [JsonPropertyName("restorableDroppedDatabaseId")]
        public string RestorableDroppedDatabaseId { get; set; }

        /// <summary>
        /// Conditional. If createMode is PointInTimeRestore, this value is required. Specifies the point in time (ISO8601 format) of the source database that will be restored to create the new database.
        /// </summary>
        [JsonPropertyName("restorePointInTime")]
        public DateTime RestorePointInTime { get; set; }

        /// <summary>
        /// The resource identifier of the source database associated with create operation of this database.
        /// </summary>
        [JsonPropertyName("sourceDatabaseId")]
        public string SourceDatabaseId { get; set; }

        /// <summary>
        /// Conditional. If createMode is RestoreExternalBackup, this value is required. Specifies the storage container sas token.
        /// </summary>
        [JsonPropertyName("storageContainerSasToken")]
        public string StorageContainerSasToken { get; set; }

        /// <summary>
        /// Conditional. If createMode is RestoreExternalBackup, this value is required. Specifies the uri of the storage container where backups for this restore are stored.
        /// </summary>
        [JsonPropertyName("storageContainerUri")]
        public string StorageContainerUri { get; set; }
    }
}