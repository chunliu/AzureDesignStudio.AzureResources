// Licensed under the MIT License.  See LICENSE in the project root for license information.

using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using AzureDesignStudio.AzureResources.Base;

namespace AzureDesignStudio.AzureResources.Storage
{
    /// <summary>
    /// The Storage Account Local User properties.
    /// </summary>
    [GeneratedCode("ArmTypeGenerator", "0.1.8.0")]
    public partial class LocalUserProperties
    {
        /// <summary>
        /// Indicates whether shared key exists. Set it to false to remove existing shared key.
        /// </summary>
        [JsonPropertyName("hasSharedKey")]
        public bool HasSharedKey { get; set; }

        /// <summary>
        /// Indicates whether ssh key exists. Set it to false to remove existing SSH key.
        /// </summary>
        [JsonPropertyName("hasSshKey")]
        public bool HasSshKey { get; set; }

        /// <summary>
        /// Indicates whether ssh password exists. Set it to false to remove existing SSH password.
        /// </summary>
        [JsonPropertyName("hasSshPassword")]
        public bool HasSshPassword { get; set; }

        /// <summary>
        /// Optional, local user home directory.
        /// </summary>
        [JsonPropertyName("homeDirectory")]
        public string HomeDirectory { get; set; }

        /// <summary>
        /// The permission scopes of the local user.
        /// </summary>
        [JsonPropertyName("permissionScopes")]
        public IList<PermissionScope> PermissionScopes { get; set; }

        /// <summary>
        /// Optional, local user ssh authorized keys for SFTP.
        /// </summary>
        [JsonPropertyName("sshAuthorizedKeys")]
        public IList<SshPublicKey> SshAuthorizedKeys { get; set; }
    }
}