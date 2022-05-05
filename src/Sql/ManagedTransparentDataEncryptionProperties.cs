// Licensed under the MIT License.  See LICENSE in the project root for license information.

using System;
using System.CodeDom.Compiler;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using AzureDesignStudio.AzureResources.Base;

namespace AzureDesignStudio.AzureResources.Sql
{
    /// <summary>
    /// Properties of a transparent data encryption.
    /// </summary>
    [GeneratedCode("ArmTypeGenerator", "0.1.8.0")]
    public partial class ManagedTransparentDataEncryptionProperties
    {
        /// <summary>
        /// Specifies the state of the transparent data encryption.
        /// </summary>
        [Required]
        [JsonPropertyName("state")]
        public string State { get; set; }
    }
}