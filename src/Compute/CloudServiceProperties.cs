// Licensed under the MIT License.  See LICENSE in the project root for license information.

using System;
using System.CodeDom.Compiler;
using System.Text.Json.Serialization;
using AzureDesignStudio.AzureResources.Base;

namespace AzureDesignStudio.AzureResources.Compute
{
    /// <summary>
    /// Cloud service properties
    /// </summary>
    [GeneratedCode("ArmTypeGenerator", "0.1.8.0")]
    public partial class CloudServiceProperties
    {
        /// <summary>
        /// (Optional) Indicates whether the role sku properties (roleProfile.roles.sku) specified in the model/template should override the role instance count and vm size specified in the .cscfg and .csdef respectively.
        [JsonPropertyName("allowModelOverride")]
        public bool AllowModelOverride { get; set; }

        /// <summary>
        /// Specifies the XML service configuration (.cscfg) for the cloud service.
        /// </summary>
        [JsonPropertyName("configuration")]
        public string Configuration { get; set; }

        /// <summary>
        /// Specifies a URL that refers to the location of the service configuration in the Blob service. The service package URL  can be Shared Access Signature (SAS) URI from any storage account.
        [JsonPropertyName("configurationUrl")]
        public string ConfigurationUrl { get; set; }

        /// <summary>
        /// Describes a cloud service extension profile.
        /// </summary>
        [JsonPropertyName("extensionProfile")]
        public CloudServiceExtensionProfile ExtensionProfile { get; set; }

        /// <summary>
        /// Network Profile for the cloud service.
        /// </summary>
        [JsonPropertyName("networkProfile")]
        public CloudServiceNetworkProfile NetworkProfile { get; set; }

        /// <summary>
        /// Describes the OS profile for the cloud service.
        /// </summary>
        [JsonPropertyName("osProfile")]
        public CloudServiceOsProfile OsProfile { get; set; }

        /// <summary>
        /// Specifies a URL that refers to the location of the service package in the Blob service. The service package URL can be Shared Access Signature (SAS) URI from any storage account.
        [JsonPropertyName("packageUrl")]
        public string PackageUrl { get; set; }

        /// <summary>
        /// Describes the role profile for the cloud service.
        /// </summary>
        [JsonPropertyName("roleProfile")]
        public CloudServiceRoleProfile RoleProfile { get; set; }

        /// <summary>
        /// (Optional) Indicates whether to start the cloud service immediately after it is created. The default value is `true`.
        [JsonPropertyName("startCloudService")]
        public bool StartCloudService { get; set; }
        [JsonPropertyName("upgradeMode")]
        public string UpgradeMode { get; set; }
    }
}