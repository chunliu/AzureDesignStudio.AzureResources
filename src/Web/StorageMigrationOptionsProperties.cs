// Licensed under the MIT License.  See LICENSE in the project root for license information.

using System;
using System.CodeDom.Compiler;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using AzureDesignStudio.AzureResources.Base;

namespace AzureDesignStudio.AzureResources.Web
{
    /// <summary>
    /// StorageMigrationOptions resource specific properties
    /// </summary>
    [GeneratedCode("ArmTypeGenerator", "0.1.8.0")]
    public partial class StorageMigrationOptionsProperties
    {
        /// <summary>
        /// AzureFiles connection string.
        /// </summary>
        [Required]
        [JsonPropertyName("azurefilesConnectionString")]
        public string AzurefilesConnectionString { get; set; }

        /// <summary>
        /// AzureFiles share.
        /// </summary>
        [Required]
        [JsonPropertyName("azurefilesShare")]
        public string AzurefilesShare { get; set; }

        /// <summary>
        /// <code>true</code> if the app should be read only during copy operation; otherwise, <code>false</code>.
        /// </summary>
        [JsonPropertyName("blockWriteAccessToSite")]
        public bool BlockWriteAccessToSite { get; set; }

        /// <summary>
        /// <code>true</code>if the app should be switched over; otherwise, <code>false</code>.
        /// </summary>
        [JsonPropertyName("switchSiteAfterMigration")]
        public bool SwitchSiteAfterMigration { get; set; }
    }
}