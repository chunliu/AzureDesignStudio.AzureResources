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
    /// Properties of a instance failover group.
    /// </summary>
    [GeneratedCode("ArmTypeGenerator", "0.1.8.0")]
    public partial class InstanceFailoverGroupProperties
    {
        /// <summary>
        /// List of managed instance pairs in the failover group.
        /// </summary>
        [Required]
        [JsonPropertyName("managedInstancePairs")]
        public IList<ManagedInstancePairInfo> ManagedInstancePairs { get; set; }

        /// <summary>
        /// Partner region information for the failover group.
        /// </summary>
        [Required]
        [JsonPropertyName("partnerRegions")]
        public IList<PartnerRegionInfo> PartnerRegions { get; set; }

        /// <summary>
        /// Read-only endpoint of the failover group instance.
        /// </summary>
        [JsonPropertyName("readOnlyEndpoint")]
        public InstanceFailoverGroupReadOnlyEndpoint ReadOnlyEndpoint { get; set; }

        /// <summary>
        /// Read-write endpoint of the failover group instance.
        /// </summary>
        [Required]
        [JsonPropertyName("readWriteEndpoint")]
        public InstanceFailoverGroupReadWriteEndpoint ReadWriteEndpoint { get; set; }
    }
}