// Licensed under the MIT License.  See LICENSE in the project root for license information.

using System;
using System.CodeDom.Compiler;
using System.Text.Json.Serialization;
using AzureDesignStudio.AzureResources.Base;

namespace AzureDesignStudio.AzureResources.Storage
{
    /// <summary>
    /// This property enables and defines account-level immutability. Enabling the feature auto-enables Blob Versioning.
    /// </summary>
    [GeneratedCode("ArmTypeGenerator", "0.1.8.0")]
    public partial class ImmutableStorageAccount
    {
        /// <summary>
        /// A boolean flag which enables account-level immutability. All the containers under such an account have object-level immutability enabled by default.
        /// </summary>
        [JsonPropertyName("enabled")]
        public bool Enabled { get; set; }

        /// <summary>
        /// This defines account-level immutability policy properties.
        /// </summary>
        [JsonPropertyName("immutabilityPolicy")]
        public AccountImmutabilityPolicyProperties ImmutabilityPolicy { get; set; }
    }
}