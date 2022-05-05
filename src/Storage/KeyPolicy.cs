// Licensed under the MIT License.  See LICENSE in the project root for license information.

using System;
using System.CodeDom.Compiler;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using AzureDesignStudio.AzureResources.Base;

namespace AzureDesignStudio.AzureResources.Storage
{
    /// <summary>
    /// KeyPolicy assigned to the storage account.
    /// </summary>
    [GeneratedCode("ArmTypeGenerator", "0.1.8.0")]
    public partial class KeyPolicy
    {
        /// <summary>
        /// The key expiration period in days.
        /// </summary>
        [Required]
        [JsonPropertyName("keyExpirationPeriodInDays")]
        public int KeyExpirationPeriodInDays { get; set; }
    }
}