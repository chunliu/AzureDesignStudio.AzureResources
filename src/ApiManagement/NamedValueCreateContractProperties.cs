// Licensed under the MIT License.  See LICENSE in the project root for license information.

using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using AzureDesignStudio.AzureResources.Base;

namespace AzureDesignStudio.AzureResources.ApiManagement
{
    /// <summary>
    /// NamedValue Contract properties.
    /// </summary>
    [GeneratedCode("ArmTypeGenerator", "0.1.8.0")]
    public partial class NamedValueCreateContractProperties
    {
        /// <summary>
        /// Unique name of NamedValue. It may contain only letters, digits, period, dash, and underscore characters.
        /// </summary>
        [Required]
        [JsonPropertyName("displayName")]
        public string DisplayName { get; set; }

        /// <summary>
        /// Create keyVault contract details.
        /// </summary>
        [JsonPropertyName("keyVault")]
        public KeyVaultContractCreateProperties KeyVault { get; set; }

        /// <summary>
        /// Determines whether the value is a secret and should be encrypted or not. Default value is false.
        /// </summary>
        [JsonPropertyName("secret")]
        public bool Secret { get; set; }

        /// <summary>
        /// Optional tags that when provided can be used to filter the NamedValue list.
        /// </summary>
        [JsonPropertyName("tags")]
        public IList<string> Tags { get; set; }

        /// <summary>
        /// Value of the NamedValue. Can contain policy expressions. It may not be empty or consist only of whitespace. This property will not be filled on 'GET' operations! Use '/listSecrets' POST request to get the value.
        /// </summary>
        [JsonPropertyName("value")]
        public string Value { get; set; }
    }
}