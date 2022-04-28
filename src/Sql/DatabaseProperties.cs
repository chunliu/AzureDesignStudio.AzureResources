using System;
using System.CodeDom.Compiler;
using System.Text.Json.Serialization;
using AzureDesignStudio.AzureResources.Base;

namespace AzureDesignStudio.AzureResources.Sql
{
    /// <summary>
    /// The database's properties.
    /// </summary>
    [GeneratedCode("Microsoft.Json.Schema.ToDotNet", "1.1.3.0")]
    public partial class DatabaseProperties
    {
        /// <summary>
        /// Time in minutes after which database is automatically paused. A value of -1 means that automatic pause is disabled
        /// </summary>
        [JsonPropertyName("autoPauseDelay")]
        public int AutoPauseDelay { get; set; }

        /// <summary>
        /// Collation of the metadata catalog.
        /// </summary>
        [JsonPropertyName("catalogCollation")]
        public string CatalogCollation { get; set; }

        /// <summary>
        /// The collation of the database.
        /// </summary>
        [JsonPropertyName("collation")]
        public string Collation { get; set; }

        /// <summary>
        /// Specifies the mode of database creation.

        [JsonPropertyName("createMode")]
        public string CreateMode { get; set; }

        /// <summary>
        /// The resource identifier of the elastic pool containing this database.
        /// </summary>
        [JsonPropertyName("elasticPoolId")]
        public string ElasticPoolId { get; set; }

        /// <summary>
        /// The number of secondary replicas associated with the database that are used to provide high availability.
        /// </summary>
        [JsonPropertyName("highAvailabilityReplicaCount")]
        public int HighAvailabilityReplicaCount { get; set; }

        /// <summary>
        /// Whether or not this database is a ledger database, which means all tables in the database are ledger tables. Note: the value of this property cannot be changed after the database has been created.
        /// </summary>
        [JsonPropertyName("isLedgerOn")]
        public bool IsLedgerOn { get; set; }

        /// <summary>
        /// The license type to apply for this database. `LicenseIncluded` if you need a license, or `BasePrice` if you have a license and are eligible for the Azure Hybrid Benefit.
        /// </summary>
        [JsonPropertyName("licenseType")]
        public string LicenseType { get; set; }

        /// <summary>
        /// The resource identifier of the long term retention backup associated with create operation of this database.
        /// </summary>
        [JsonPropertyName("longTermRetentionBackupResourceId")]
        public string LongTermRetentionBackupResourceId { get; set; }

        /// <summary>
        /// Maintenance configuration id assigned to the database. This configuration defines the period when the maintenance updates will occur.
        /// </summary>
        [JsonPropertyName("maintenanceConfigurationId")]
        public string MaintenanceConfigurationId { get; set; }

        /// <summary>
        /// The max size of the database expressed in bytes.
        /// </summary>
        [JsonPropertyName("maxSizeBytes")]
        public int MaxSizeBytes { get; set; }

        /// <summary>
        /// Minimal capacity that database will always have allocated, if not paused
        /// </summary>
        [JsonPropertyName("minCapacity")]
        public double MinCapacity { get; set; }

        /// <summary>
        /// The state of read-only routing. If enabled, connections that have application intent set to readonly in their connection string may be routed to a readonly secondary replica in the same region.
        /// </summary>
        [JsonPropertyName("readScale")]
        public string ReadScale { get; set; }

        /// <summary>
        /// The resource identifier of the recoverable database associated with create operation of this database.
        /// </summary>
        [JsonPropertyName("recoverableDatabaseId")]
        public string RecoverableDatabaseId { get; set; }

        /// <summary>
        /// The resource identifier of the recovery point associated with create operation of this database.
        /// </summary>
        [JsonPropertyName("recoveryServicesRecoveryPointId")]
        public string RecoveryServicesRecoveryPointId { get; set; }

        /// <summary>
        /// The storage account type to be used to store backups for this database.
        /// </summary>
        [JsonPropertyName("requestedBackupStorageRedundancy")]
        public string RequestedBackupStorageRedundancy { get; set; }

        /// <summary>
        /// The resource identifier of the restorable dropped database associated with create operation of this database.
        /// </summary>
        [JsonPropertyName("restorableDroppedDatabaseId")]
        public string RestorableDroppedDatabaseId { get; set; }

        /// <summary>
        /// Specifies the point in time (ISO8601 format) of the source database that will be restored to create the new database.
        /// </summary>
        [JsonPropertyName("restorePointInTime")]
        public DateTime RestorePointInTime { get; set; }

        /// <summary>
        /// The name of the sample schema to apply when creating this database.
        /// </summary>
        [JsonPropertyName("sampleName")]
        public string SampleName { get; set; }

        /// <summary>
        /// The secondary type of the database if it is a secondary.  Valid values are Geo and Named.
        /// </summary>
        [JsonPropertyName("secondaryType")]
        public string SecondaryType { get; set; }

        /// <summary>
        /// Specifies the time that the database was deleted.
        /// </summary>
        [JsonPropertyName("sourceDatabaseDeletionDate")]
        public DateTime SourceDatabaseDeletionDate { get; set; }

        /// <summary>
        /// The resource identifier of the source database associated with create operation of this database.
        /// </summary>
        [JsonPropertyName("sourceDatabaseId")]
        public string SourceDatabaseId { get; set; }

        /// <summary>
        /// Whether or not this database is zone redundant, which means the replicas of this database will be spread across multiple availability zones.
        /// </summary>
        [JsonPropertyName("zoneRedundant")]
        public bool ZoneRedundant { get; set; }
    }
}