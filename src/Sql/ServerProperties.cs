// Licensed under the MIT License.  See LICENSE in the project root for license information.

using System;
using System.CodeDom.Compiler;
using System.Text.Json.Serialization;
using AzureDesignStudio.AzureResources.Base;

namespace AzureDesignStudio.AzureResources.Sql
{
    /// <summary>
    /// The properties of a server.
    /// </summary>
    [GeneratedCode("ArmTypeGenerator", "0.1.8.0")]
    public partial class ServerProperties
    {
        /// <summary>
        /// Administrator username for the server. Once created it cannot be changed.
        /// </summary>
        [JsonPropertyName("administratorLogin")]
        public string AdministratorLogin { get; set; }

        /// <summary>
        /// The administrator login password (required for server creation).
        /// </summary>
        [JsonPropertyName("administratorLoginPassword")]
        public string AdministratorLoginPassword { get; set; }

        /// <summary>
        /// Properties of a active directory administrator.
        /// </summary>
        [JsonPropertyName("administrators")]
        public ServerExternalAdministrator Administrators { get; set; }

        /// <summary>
        /// The Client id used for cross tenant CMK scenario
        /// </summary>
        [JsonPropertyName("federatedClientId")]
        public string FederatedClientId { get; set; }

        /// <summary>
        /// A CMK URI of the key to use for encryption.
        /// </summary>
        [JsonPropertyName("keyId")]
        public string KeyId { get; set; }

        /// <summary>
        /// Minimal TLS version. Allowed values: '1.0', '1.1', '1.2'
        /// </summary>
        [JsonPropertyName("minimalTlsVersion")]
        public string MinimalTlsVersion { get; set; }

        /// <summary>
        /// The resource id of a user assigned identity to be used by default.
        /// </summary>
        [JsonPropertyName("primaryUserAssignedIdentityId")]
        public string PrimaryUserAssignedIdentityId { get; set; }

        /// <summary>
        /// Whether or not public endpoint access is allowed for this server.  Value is optional but if passed in, must be 'Enabled' or 'Disabled'.
        /// </summary>
        [JsonPropertyName("publicNetworkAccess")]
        public string PublicNetworkAccess { get; set; }

        /// <summary>
        /// Whether or not to restrict outbound network access for this server.  Value is optional but if passed in, must be 'Enabled' or 'Disabled'.
        /// </summary>
        [JsonPropertyName("restrictOutboundNetworkAccess")]
        public string RestrictOutboundNetworkAccess { get; set; }

        /// <summary>
        /// The version of the server.
        /// </summary>
        [JsonPropertyName("version")]
        public string Version { get; set; }
    }
}