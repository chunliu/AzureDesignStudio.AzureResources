// Licensed under the MIT License.  See LICENSE in the project root for license information.

using System;
using System.CodeDom.Compiler;
using System.Text.Json.Serialization;
using AzureDesignStudio.AzureResources.Base;

namespace AzureDesignStudio.AzureResources.Web
{
    /// <summary>
    /// Database connection string information.
    /// </summary>
    [GeneratedCode("ArmTypeGenerator", "0.1.8.0")]
    public partial class ConnStringInfo
    {
        /// <summary>
        /// Connection string value.
        /// </summary>
        [JsonPropertyName("connectionString")]
        public string ConnectionString { get; set; }

        /// <summary>
        /// Name of connection string.
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; set; }

        /// <summary>
        /// Type of database.
        /// </summary>
        [JsonPropertyName("type")]
        public string Type { get; set; }
    }
}