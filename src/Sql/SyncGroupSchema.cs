// Licensed under the MIT License.  See LICENSE in the project root for license information.

using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using AzureDesignStudio.AzureResources.Base;

namespace AzureDesignStudio.AzureResources.Sql
{
    /// <summary>
    /// Properties of sync group schema.
    /// </summary>
    [GeneratedCode("ArmTypeGenerator", "0.1.8.0")]
    public partial class SyncGroupSchema
    {
        /// <summary>
        /// Name of master sync member where the schema is from.
        /// </summary>
        [JsonPropertyName("masterSyncMemberName")]
        public string MasterSyncMemberName { get; set; }

        /// <summary>
        /// List of tables in sync group schema.
        /// </summary>
        [JsonPropertyName("tables")]
        public IList<SyncGroupSchemaTable> Tables { get; set; }
    }
}