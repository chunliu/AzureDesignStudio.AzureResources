// Licensed under the MIT License.  See LICENSE in the project root for license information.

using System;
using System.CodeDom.Compiler;
using System.Text.Json.Serialization;
using AzureDesignStudio.AzureResources.Base;

namespace AzureDesignStudio.AzureResources.Storage
{
    /// <summary>
    /// The parameters used to create the storage account.
    /// </summary>
    [GeneratedCode("ArmTypeGenerator", "0.1.8.0")]
    public partial class StorageAccountPropertiesCreateParameters
    {
        /// <summary>
        /// Required for storage accounts where kind = BlobStorage. The access tier is used for billing. The 'Premium' access tier is the default value for premium block blobs storage account type and it cannot be changed for the premium block blobs storage account type.
        /// </summary>
        [JsonPropertyName("accessTier")]
        public string AccessTier { get; set; }

        /// <summary>
        /// Allow or disallow public access to all blobs or containers in the storage account. The default interpretation is true for this property.
        /// </summary>
        [JsonPropertyName("allowBlobPublicAccess")]
        public bool AllowBlobPublicAccess { get; set; }

        /// <summary>
        /// Allow or disallow cross AAD tenant object replication. The default interpretation is true for this property.
        /// </summary>
        [JsonPropertyName("allowCrossTenantReplication")]
        public bool AllowCrossTenantReplication { get; set; }

        /// <summary>
        /// Restrict copy to and from Storage Accounts within an AAD tenant or with Private Links to the same VNet.
        /// </summary>
        [JsonPropertyName("allowedCopyScope")]
        public string AllowedCopyScope { get; set; }

        /// <summary>
        /// Indicates whether the storage account permits requests to be authorized with the account access key via Shared Key. If false, then all requests, including shared access signatures, must be authorized with Azure Active Directory (Azure AD). The default value is null, which is equivalent to true.
        /// </summary>
        [JsonPropertyName("allowSharedKeyAccess")]
        public bool AllowSharedKeyAccess { get; set; }

        /// <summary>
        /// Settings for Azure Files identity based authentication.
        /// </summary>
        [JsonPropertyName("azureFilesIdentityBasedAuthentication")]
        public AzureFilesIdentityBasedAuthentication AzureFilesIdentityBasedAuthentication { get; set; }

        /// <summary>
        /// The custom domain assigned to this storage account. This can be set via Update.
        /// </summary>
        [JsonPropertyName("customDomain")]
        public CustomDomain CustomDomain { get; set; }

        /// <summary>
        /// A boolean flag which indicates whether the default authentication is OAuth or not. The default interpretation is false for this property.
        /// </summary>
        [JsonPropertyName("defaultToOAuthAuthentication")]
        public bool DefaultToOAuthAuthentication { get; set; }

        /// <summary>
        /// Allows you to specify the type of endpoint. Set this to AzureDNSZone to create a large number of accounts in a single subscription, which creates accounts in an Azure DNS Zone and the endpoint URL will have an alphanumeric DNS Zone identifier.
        /// </summary>
        [JsonPropertyName("dnsEndpointType")]
        public string DnsEndpointType { get; set; }

        /// <summary>
        /// The encryption settings on the storage account.
        /// </summary>
        [JsonPropertyName("encryption")]
        public Encryption Encryption { get; set; }

        /// <summary>
        /// This property enables and defines account-level immutability. Enabling the feature auto-enables Blob Versioning.
        /// </summary>
        [JsonPropertyName("immutableStorageWithVersioning")]
        public ImmutableStorageAccount ImmutableStorageWithVersioning { get; set; }

        /// <summary>
        /// Account HierarchicalNamespace enabled if sets to true.
        /// </summary>
        [JsonPropertyName("isHnsEnabled")]
        public bool IsHnsEnabled { get; set; }

        /// <summary>
        /// Enables local users feature, if set to true
        /// </summary>
        [JsonPropertyName("isLocalUserEnabled")]
        public bool IsLocalUserEnabled { get; set; }

        /// <summary>
        /// NFS 3.0 protocol support enabled if set to true.
        /// </summary>
        [JsonPropertyName("isNfsV3Enabled")]
        public bool IsNfsV3Enabled { get; set; }

        /// <summary>
        /// Enables Secure File Transfer Protocol, if set to true
        /// </summary>
        [JsonPropertyName("isSftpEnabled")]
        public bool IsSftpEnabled { get; set; }

        /// <summary>
        /// KeyPolicy assigned to the storage account.
        /// </summary>
        [JsonPropertyName("keyPolicy")]
        public KeyPolicy KeyPolicy { get; set; }

        /// <summary>
        /// Allow large file shares if sets to Enabled. It cannot be disabled once it is enabled.
        /// </summary>
        [JsonPropertyName("largeFileSharesState")]
        public string LargeFileSharesState { get; set; }

        /// <summary>
        /// Set the minimum TLS version to be permitted on requests to storage. The default interpretation is TLS 1.0 for this property.
        /// </summary>
        [JsonPropertyName("minimumTlsVersion")]
        public string MinimumTlsVersion { get; set; }

        /// <summary>
        /// Network rule set
        /// </summary>
        [JsonPropertyName("networkAcls")]
        public NetworkRuleSet NetworkAcls { get; set; }

        /// <summary>
        /// Allow or disallow public network access to Storage Account. Value is optional but if passed in, must be 'Enabled' or 'Disabled'.
        /// </summary>
        [JsonPropertyName("publicNetworkAccess")]
        public string PublicNetworkAccess { get; set; }

        /// <summary>
        /// Routing preference defines the type of network, either microsoft or internet routing to be used to deliver the user data, the default option is microsoft routing
        /// </summary>
        [JsonPropertyName("routingPreference")]
        public RoutingPreference RoutingPreference { get; set; }

        /// <summary>
        /// SasPolicy assigned to the storage account.
        /// </summary>
        [JsonPropertyName("sasPolicy")]
        public SasPolicy SasPolicy { get; set; }

        /// <summary>
        /// Allows https traffic only to storage service if sets to true. The default value is true since API version 2019-04-01.
        /// </summary>
        [JsonPropertyName("supportsHttpsTrafficOnly")]
        public bool SupportsHttpsTrafficOnly { get; set; }
    }
}