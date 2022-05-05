// Licensed under the MIT License.  See LICENSE in the project root for license information.

using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using AzureDesignStudio.AzureResources.Base;

namespace AzureDesignStudio.AzureResources.Web
{
    /// <summary>
    /// MSDeploy ARM PUT core information
    /// </summary>
    [GeneratedCode("ArmTypeGenerator", "0.1.8.0")]
    public partial class MSDeployCore
    {
        /// <summary>
        /// Sets the AppOffline rule while the MSDeploy operation executes.
        [JsonPropertyName("appOffline")]
        public bool AppOffline { get; set; }

        /// <summary>
        /// SQL Connection String
        /// </summary>
        [JsonPropertyName("connectionString")]
        public string ConnectionString { get; set; }

        /// <summary>
        /// Database Type
        /// </summary>
        [JsonPropertyName("dbType")]
        public string DbType { get; set; }

        /// <summary>
        /// Package URI
        /// </summary>
        [JsonPropertyName("packageUri")]
        public string PackageUri { get; set; }

        /// <summary>
        /// MSDeploy Parameters. Must not be set if SetParametersXmlFileUri is used.
        /// </summary>
        [JsonPropertyName("setParameters")]
        public IDictionary<string, string> SetParameters { get; set; }

        /// <summary>
        /// URI of MSDeploy Parameters file. Must not be set if SetParameters is used.
        /// </summary>
        [JsonPropertyName("setParametersXmlFileUri")]
        public string SetParametersXmlFileUri { get; set; }

        /// <summary>
        /// Controls whether the MSDeploy operation skips the App_Data directory.
        [JsonPropertyName("skipAppData")]
        public bool SkipAppData { get; set; }
    }
}