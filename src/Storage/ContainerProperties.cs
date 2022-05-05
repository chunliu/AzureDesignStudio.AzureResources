// Licensed under the MIT License.  See LICENSE in the project root for license information.

using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using AzureDesignStudio.AzureResources.Base;

namespace AzureDesignStudio.AzureResources.Storage
{
    /// <summary>
    /// The properties of a container.
    /// </summary>
    [GeneratedCode("ArmTypeGenerator", "0.1.8.0")]
    public partial class ContainerProperties
    {
        /// <summary>
        /// Default the container to use specified encryption scope for all writes.
        /// </summary>
        [JsonPropertyName("defaultEncryptionScope")]
        public string DefaultEncryptionScope { get; set; }

        /// <summary>
        /// Block override of encryption scope from the container default.
        /// </summary>
        [JsonPropertyName("denyEncryptionScopeOverride")]
        public bool DenyEncryptionScopeOverride { get; set; }

        /// <summary>
        /// Enable NFSv3 all squash on blob container.
        /// </summary>
        [JsonPropertyName("enableNfsV3AllSquash")]
        public bool EnableNfsV3AllSquash { get; set; }

        /// <summary>
        /// Enable NFSv3 root squash on blob container.
        /// </summary>
        [JsonPropertyName("enableNfsV3RootSquash")]
        public bool EnableNfsV3RootSquash { get; set; }

        /// <summary>
        /// Object level immutability properties of the container.
        /// </summary>
        [JsonPropertyName("immutableStorageWithVersioning")]
        public ImmutableStorageWithVersioning ImmutableStorageWithVersioning { get; set; }

        /// <summary>
        /// A name-value pair to associate with the container as metadata.
        /// </summary>
        [JsonPropertyName("metadata")]
        public IDictionary<string, string> Metadata { get; set; }

        /// <summary>
        /// Specifies whether data in the container may be accessed publicly and the level of access.
        /// </summary>
        [JsonPropertyName("publicAccess")]
        public string PublicAccess { get; set; }
    }
}