// Licensed under the MIT License.  See LICENSE in the project root for license information.

using System;
using System.CodeDom.Compiler;
using System.Text.Json.Serialization;
using AzureDesignStudio.AzureResources.Base;

namespace AzureDesignStudio.AzureResources.Sql
{
    /// <summary>
    /// Properties of column in sync group table.
    /// </summary>
    [GeneratedCode("ArmTypeGenerator", "0.1.8.0")]
    public partial class SyncGroupSchemaTableColumn
    {
        /// <summary>
        /// Data size of the column.
        /// </summary>
        [JsonPropertyName("dataSize")]
        public string DataSize { get; set; }

        /// <summary>
        /// Data type of the column.
        /// </summary>
        [JsonPropertyName("dataType")]
        public string DataType { get; set; }

        /// <summary>
        /// Quoted name of sync group table column.
        /// </summary>
        [JsonPropertyName("quotedName")]
        public string QuotedName { get; set; }
    }
}