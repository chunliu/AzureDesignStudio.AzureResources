// Licensed under the MIT License.  See LICENSE in the project root for license information.

using System;
using System.CodeDom.Compiler;
using System.Text.Json.Serialization;
using AzureDesignStudio.AzureResources.Base;

namespace AzureDesignStudio.AzureResources.Sql
{
    /// <summary>
    /// The properties of a database ledger digest upload settings.
    /// </summary>
    [GeneratedCode("ArmTypeGenerator", "0.1.8.0")]
    public partial class LedgerDigestUploadsProperties
    {
        /// <summary>
        /// The digest storage endpoint, which must be either an Azure blob storage endpoint or an URI for Azure Confidential Ledger.
        /// </summary>
        [JsonPropertyName("digestStorageEndpoint")]
        public string DigestStorageEndpoint { get; set; }
    }
}