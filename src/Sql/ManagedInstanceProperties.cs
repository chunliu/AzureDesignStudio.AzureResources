// Licensed under the MIT License.  See LICENSE in the project root for license information.

using System;
using System.CodeDom.Compiler;
using System.Text.Json.Serialization;
using AzureDesignStudio.AzureResources.Base;

namespace AzureDesignStudio.AzureResources.Sql
{
    /// <summary>
    /// The properties of a managed instance.
    /// </summary>
    [GeneratedCode("ArmTypeGenerator", "0.1.8.0")]
    public partial class ManagedInstanceProperties
    {
        /// <summary>
        /// Administrator username for the managed instance. Can only be specified when the managed instance is being created (and is required for creation).
        /// </summary>
        [JsonPropertyName("administratorLogin")]
        public string AdministratorLogin { get; set; }

        /// <summary>
        /// The administrator login password (required for managed instance creation).
        /// </summary>
        [JsonPropertyName("administratorLoginPassword")]
        public string AdministratorLoginPassword { get; set; }

        /// <summary>
        /// Properties of a active directory administrator.
        /// </summary>
        [JsonPropertyName("administrators")]
        public ManagedInstanceExternalAdministrator Administrators { get; set; }

        /// <summary>
        /// Collation of the managed instance.
        /// </summary>
        [JsonPropertyName("collation")]
        public string Collation { get; set; }

        /// <summary>
        /// The resource id of another managed instance whose DNS zone this managed instance will share after creation.
        /// </summary>
        [JsonPropertyName("dnsZonePartner")]
        public string DnsZonePartner { get; set; }

        /// <summary>
        /// The Id of the instance pool this managed server belongs to.
        /// </summary>
        [JsonPropertyName("instancePoolId")]
        public string InstancePoolId { get; set; }

        /// <summary>
        /// A CMK URI of the key to use for encryption.
        /// </summary>
        [JsonPropertyName("keyId")]
        public string KeyId { get; set; }

        /// <summary>
        /// The license type. Possible values are 'LicenseIncluded' (regular price inclusive of a new SQL license) and 'BasePrice' (discounted AHB price for bringing your own SQL licenses).
        /// </summary>
        [JsonPropertyName("licenseType")]
        public string LicenseType { get; set; }

        /// <summary>
        /// Specifies maintenance configuration id to apply to this managed instance.
        /// </summary>
        [JsonPropertyName("maintenanceConfigurationId")]
        public string MaintenanceConfigurationId { get; set; }

        /// <summary>
        /// Specifies the mode of database creation.

        [JsonPropertyName("managedInstanceCreateMode")]
        public string ManagedInstanceCreateMode { get; set; }

        /// <summary>
        /// Minimal TLS version. Allowed values: 'None', '1.0', '1.1', '1.2'
        /// </summary>
        [JsonPropertyName("minimalTlsVersion")]
        public string MinimalTlsVersion { get; set; }

        /// <summary>
        /// The resource id of a user assigned identity to be used by default.
        /// </summary>
        [JsonPropertyName("primaryUserAssignedIdentityId")]
        public string PrimaryUserAssignedIdentityId { get; set; }

        /// <summary>
        /// Connection type used for connecting to the instance.
        /// </summary>
        [JsonPropertyName("proxyOverride")]
        public string ProxyOverride { get; set; }

        /// <summary>
        /// Whether or not the public data endpoint is enabled.
        /// </summary>
        [JsonPropertyName("publicDataEndpointEnabled")]
        public bool PublicDataEndpointEnabled { get; set; }

        /// <summary>
        /// Specifies the point in time (ISO8601 format) of the source database that will be restored to create the new database.
        /// </summary>
        [JsonPropertyName("restorePointInTime")]
        public DateTime RestorePointInTime { get; set; }

        /// <summary>
        /// The resource identifier of the source managed instance associated with create operation of this instance.
        /// </summary>
        [JsonPropertyName("sourceManagedInstanceId")]
        public string SourceManagedInstanceId { get; set; }

        /// <summary>
        /// The storage account type used to store backups for this instance. The options are LRS (LocallyRedundantStorage), ZRS (ZoneRedundantStorage) and GRS (GeoRedundantStorage).
        /// </summary>
        [JsonPropertyName("storageAccountType")]
        public string StorageAccountType { get; set; }

        /// <summary>
        /// Storage size in GB. Minimum value: 32. Maximum value: 8192. Increments of 32 GB allowed only.
        /// </summary>
        [JsonPropertyName("storageSizeInGB")]
        public int StorageSizeInGB { get; set; }

        /// <summary>
        /// Subnet resource ID for the managed instance.
        /// </summary>
        [JsonPropertyName("subnetId")]
        public string SubnetId { get; set; }

        /// <summary>
        /// Id of the timezone. Allowed values are timezones supported by Windows.
        [JsonPropertyName("timezoneId")]
        public string TimezoneId { get; set; }

        /// <summary>
        /// The number of vCores. Allowed values: 8, 16, 24, 32, 40, 64, 80.
        /// </summary>
        [JsonPropertyName("vCores")]
        public int VCores { get; set; }

        /// <summary>
        /// Whether or not the multi-az is enabled.
        /// </summary>
        [JsonPropertyName("zoneRedundant")]
        public bool ZoneRedundant { get; set; }
    }
}