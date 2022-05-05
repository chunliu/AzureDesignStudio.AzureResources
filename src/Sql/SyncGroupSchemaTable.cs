// Licensed under the MIT License.  See LICENSE in the project root for license information.

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
    [GeneratedCode("ArmTypeGenerator", "0.1.8.0")]
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