// Licensed under the MIT License.  See LICENSE in the project root for license information.

using System;
using System.CodeDom.Compiler;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using AzureDesignStudio.AzureResources.Base;

namespace AzureDesignStudio.AzureResources.Web
{
    /// <summary>
    /// Database backup settings.
    /// </summary>
    [GeneratedCode("ArmTypeGenerator", "0.1.8.0")]
    public partial class DatabaseBackupSetting
    {
        /// <summary>
        /// Contains a connection string to a database which is being backed up or restored. If the restore should happen to a new database, the database name inside is the new one.
        /// </summary>
        [JsonPropertyName("connectionString")]
        public string ConnectionString { get; set; }

        /// <summary>
        /// Contains a connection string name that is linked to the SiteConfig.ConnectionStrings.
        [JsonPropertyName("connectionStringName")]
        public string ConnectionStringName { get; set; }

        /// <summary>
        /// Database type (e.g. SqlAzure / MySql).
        /// </summary>
        [Required]
        [JsonPropertyName("databaseType")]
        public string DatabaseType { get; set; }
        [JsonPropertyName("name")]
        public string Name { get; set; }
    }
}