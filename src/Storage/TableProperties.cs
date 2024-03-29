// Licensed under the MIT License.  See LICENSE in the project root for license information.

using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using AzureDesignStudio.AzureResources.Base;

namespace AzureDesignStudio.AzureResources.Storage
{
    [GeneratedCode("ArmTypeGenerator", "0.1.8.0")]
    public partial class TableProperties
    {
        /// <summary>
        /// List of stored access policies specified on the table.
        /// </summary>
        [JsonPropertyName("signedIdentifiers")]
        public IList<TableSignedIdentifier> SignedIdentifiers { get; set; }
    }
}