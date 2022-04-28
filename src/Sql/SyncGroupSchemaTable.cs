using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using AzureDesignStudio.AzureResources.Base;

namespace AzureDesignStudio.AzureResources.Sql
{
    /// <summary>
    /// Properties of table in sync group schema.
    /// </summary>
    [GeneratedCode("Microsoft.Json.Schema.ToDotNet", "1.1.3.0")]
    public partial class SyncGroupSchemaTable
    {
        /// <summary>
        /// List of columns in sync group schema.
        /// </summary>
        [JsonPropertyName("columns")]
        public IList<SyncGroupSchemaTableColumn> Columns { get; set; }

        /// <summary>
        /// Quoted name of sync group schema table.
        /// </summary>
        [JsonPropertyName("quotedName")]
        public string QuotedName { get; set; }
    }
}