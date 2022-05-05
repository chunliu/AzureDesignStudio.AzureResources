// Licensed under the MIT License.  See LICENSE in the project root for license information.

using System;
using System.CodeDom.Compiler;
using System.Text.Json.Serialization;
using AzureDesignStudio.AzureResources.Base;

namespace AzureDesignStudio.AzureResources.Storage
{
    /// <summary>
    /// Actions are applied to the filtered blobs when the execution condition is met.
    /// </summary>
    [GeneratedCode("ArmTypeGenerator", "0.1.8.0")]
    public partial class ManagementPolicyAction
    {
        /// <summary>
        /// Management policy action for base blob.
        /// </summary>
        [JsonPropertyName("baseBlob")]
        public ManagementPolicyBaseBlob BaseBlob { get; set; }

        /// <summary>
        /// Management policy action for snapshot.
        /// </summary>
        [JsonPropertyName("snapshot")]
        public ManagementPolicySnapShot Snapshot { get; set; }

        /// <summary>
        /// Management policy action for blob version.
        /// </summary>
        [JsonPropertyName("version")]
        public ManagementPolicyVersion Version { get; set; }
    }
}