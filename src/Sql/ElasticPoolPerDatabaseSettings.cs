// Licensed under the MIT License.  See LICENSE in the project root for license information.

using System;
using System.CodeDom.Compiler;
using System.Text.Json.Serialization;
using AzureDesignStudio.AzureResources.Base;

namespace AzureDesignStudio.AzureResources.Sql
{
    /// <summary>
    /// Per database settings of an elastic pool.
    /// </summary>
    [GeneratedCode("ArmTypeGenerator", "0.1.8.0")]
    public partial class ElasticPoolPerDatabaseSettings
    {
        /// <summary>
        /// The maximum capacity any one database can consume.
        /// </summary>
        [JsonPropertyName("maxCapacity")]
        public double MaxCapacity { get; set; }

        /// <summary>
        /// The minimum capacity all databases are guaranteed.
        /// </summary>
        [JsonPropertyName("minCapacity")]
        public double MinCapacity { get; set; }
    }
}