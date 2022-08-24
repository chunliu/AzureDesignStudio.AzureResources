// Licensed under the MIT License.  See LICENSE in the project root for license information.

using System;
using System.CodeDom.Compiler;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using AzureDesignStudio.AzureResources.Base;

namespace AzureDesignStudio.AzureResources.Sql
{
    /// <summary>
    /// The properties of a database data masking policy.
    /// </summary>
    [GeneratedCode("ArmTypeGenerator", "0.1.8.0")]
    public partial class DataMaskingPolicyProperties
    {
        /// <summary>
        /// The state of the data masking policy.
        /// </summary>
        [Required]
        [JsonPropertyName("dataMaskingState")]
        public string DataMaskingState { get; set; }

        /// <summary>
        /// The list of the exempt principals. Specifies the semicolon-separated list of database users for which the data masking policy does not apply. The specified users receive data results without masking for all of the database queries.
        /// </summary>
        [JsonPropertyName("exemptPrincipals")]
        public string ExemptPrincipals { get; set; }
    }
}