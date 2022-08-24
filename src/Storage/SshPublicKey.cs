// Licensed under the MIT License.  See LICENSE in the project root for license information.

using System;
using System.CodeDom.Compiler;
using System.Text.Json.Serialization;
using AzureDesignStudio.AzureResources.Base;

namespace AzureDesignStudio.AzureResources.Storage
{
    [GeneratedCode("ArmTypeGenerator", "0.1.8.0")]
    public partial class SshPublicKey
    {
        /// <summary>
        /// Optional. It is used to store the function/usage of the key
        /// </summary>
        [JsonPropertyName("description")]
        public string Description { get; set; }

        /// <summary>
        /// Ssh public key base64 encoded. The format should be: '<keyType> <keyData>', e.g. ssh-rsa AAAABBBB
        /// </summary>
        [JsonPropertyName("key")]
        public string Key { get; set; }
    }
}