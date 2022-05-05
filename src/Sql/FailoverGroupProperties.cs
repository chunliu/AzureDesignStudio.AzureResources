// Licensed under the MIT License.  See LICENSE in the project root for license information.

using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using AzureDesignStudio.AzureResources.Base;

namespace AzureDesignStudio.AzureResources.Sql
{
    /// <summary>
    /// Properties of a failover group.
    /// </summary>
    [GeneratedCode("ArmTypeGenerator", "0.1.8.0")]
    public partial class FailoverGroupProperties
    {
        /// <summary>
        /// List of databases in the failover group.
        /// </summary>
        [JsonPropertyName("databases")]
        public IList<string> Databases { get; set; }

        /// <summary>
        /// List of partner server information for the failover group.
        /// </summary>
        [Required]
        [JsonPropertyName("partnerServers")]
        public IList<PartnerInfo> PartnerServers { get; set; }

        /// <summary>
        /// Read-only endpoint of the failover group instance.
        /// </summary>
        [JsonPropertyName("readOnlyEndpoint")]
        public FailoverGroupReadOnlyEndpoint ReadOnlyEndpoint { get; set; }

        /// <summary>
        /// Read-write endpoint of the failover group instance.
        /// </summary>
        [Required]
        [JsonPropertyName("readWriteEndpoint")]
        public FailoverGroupReadWriteEndpoint ReadWriteEndpoint { get; set; }
    }
}