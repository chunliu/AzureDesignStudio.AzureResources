// Licensed under the MIT License.  See LICENSE in the project root for license information.

using System;
using System.CodeDom.Compiler;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using AzureDesignStudio.AzureResources.Base;

namespace AzureDesignStudio.AzureResources.Sql
{
    /// <summary>
    /// Properties of an instance pool.
    /// </summary>
    [GeneratedCode("ArmTypeGenerator", "0.1.8.0")]
    public partial class InstancePoolProperties
    {
        /// <summary>
        /// The license type. Possible values are 'LicenseIncluded' (price for SQL license is included) and 'BasePrice' (without SQL license price).
        /// </summary>
        [Required]
        [JsonPropertyName("licenseType")]
        public string LicenseType { get; set; }

        /// <summary>
        /// Resource ID of the subnet to place this instance pool in.
        /// </summary>
        [Required]
        [JsonPropertyName("subnetId")]
        public string SubnetId { get; set; }

        /// <summary>
        /// Count of vCores belonging to this instance pool.
        /// </summary>
        [Required]
        [JsonPropertyName("vCores")]
        public int VCores { get; set; }
    }
}