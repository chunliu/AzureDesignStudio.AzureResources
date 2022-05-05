// Licensed under the MIT License.  See LICENSE in the project root for license information.

using System;
using System.CodeDom.Compiler;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using AzureDesignStudio.AzureResources.Base;

namespace AzureDesignStudio.AzureResources.Storage
{
    /// <summary>
    /// The storage account blob inventory policy properties.
    /// </summary>
    [GeneratedCode("ArmTypeGenerator", "0.1.8.0")]
    public partial class BlobInventoryPolicyProperties
    {
        /// <summary>
        /// The storage account blob inventory policy rules.
        /// </summary>
        [Required]
        [JsonPropertyName("policy")]
        public BlobInventoryPolicySchema Policy { get; set; }
    }
}