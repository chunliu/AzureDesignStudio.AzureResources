// Licensed under the MIT License.  See LICENSE in the project root for license information.

using System;
using System.CodeDom.Compiler;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using AzureDesignStudio.AzureResources.Base;

namespace AzureDesignStudio.AzureResources.Storage
{
    /// <summary>
    /// SasPolicy assigned to the storage account.
    /// </summary>
    [GeneratedCode("ArmTypeGenerator", "0.1.8.0")]
    public partial class SasPolicy
    {
        /// <summary>
        /// The SAS expiration action. Can only be Log.
        /// </summary>
        [Required]
        [JsonPropertyName("expirationAction")]
        public string ExpirationAction { get; set; }

        /// <summary>
        /// The SAS expiration period, DD.HH:MM:SS.
        /// </summary>
        [Required]
        [JsonPropertyName("sasExpirationPeriod")]
        public string SasExpirationPeriod { get; set; }
    }
}