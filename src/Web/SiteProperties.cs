// Licensed under the MIT License.  See LICENSE in the project root for license information.

using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using AzureDesignStudio.AzureResources.Base;

namespace AzureDesignStudio.AzureResources.Web
{
    /// <summary>
    /// Site resource specific properties
    /// </summary>
    [GeneratedCode("ArmTypeGenerator", "0.1.8.0")]
    public partial class SiteProperties
    {
        /// <summary>
        /// <code>true</code> to enable client affinity; <code>false</code> to stop sending session affinity cookies, which route client requests in the same session to the same instance. Default is <code>true</code>.
        /// </summary>
        [JsonPropertyName("clientAffinityEnabled")]
        public bool ClientAffinityEnabled { get; set; }

        /// <summary>
        /// <code>true</code> to enable client certificate authentication (TLS mutual authentication); otherwise, <code>false</code>. Default is <code>false</code>.
        /// </summary>
        [JsonPropertyName("clientCertEnabled")]
        public bool ClientCertEnabled { get; set; }

        /// <summary>
        /// client certificate authentication comma-separated exclusion paths
        /// </summary>
        [JsonPropertyName("clientCertExclusionPaths")]
        public string ClientCertExclusionPaths { get; set; }

        /// <summary>
        /// This composes with ClientCertEnabled setting.
        [JsonPropertyName("clientCertMode")]
        public string ClientCertMode { get; set; }

        /// <summary>
        /// Information needed for cloning operation.
        /// </summary>
        [JsonPropertyName("cloningInfo")]
        public CloningInfo CloningInfo { get; set; }

        /// <summary>
        /// Size of the function container.
        /// </summary>
        [JsonPropertyName("containerSize")]
        public int ContainerSize { get; set; }

        /// <summary>
        /// Unique identifier that verifies the custom domains assigned to the app. Customer will add this id to a txt record for verification.
        /// </summary>
        [JsonPropertyName("customDomainVerificationId")]
        public string CustomDomainVerificationId { get; set; }

        /// <summary>
        /// Maximum allowed daily memory-time quota (applicable on dynamic apps only).
        /// </summary>
        [JsonPropertyName("dailyMemoryTimeQuota")]
        public int DailyMemoryTimeQuota { get; set; }

        /// <summary>
        /// <code>true</code> if the app is enabled; otherwise, <code>false</code>. Setting this value to false disables the app (takes the app offline).
        /// </summary>
        [JsonPropertyName("enabled")]
        public bool Enabled { get; set; }

        /// <summary>
        /// Specification for an App Service Environment to use for this resource.
        /// </summary>
        [JsonPropertyName("hostingEnvironmentProfile")]
        public HostingEnvironmentProfile HostingEnvironmentProfile { get; set; }

        /// <summary>
        /// <code>true</code> to disable the public hostnames of the app; otherwise, <code>false</code>.
        [JsonPropertyName("hostNamesDisabled")]
        public bool HostNamesDisabled { get; set; }

        /// <summary>
        /// Hostname SSL states are used to manage the SSL bindings for app's hostnames.
        /// </summary>
        [JsonPropertyName("hostNameSslStates")]
        public IList<HostNameSslState> HostNameSslStates { get; set; }

        /// <summary>
        /// HttpsOnly: configures a web site to accept only https requests. Issues redirect for
        [JsonPropertyName("httpsOnly")]
        public bool HttpsOnly { get; set; }

        /// <summary>
        /// Hyper-V sandbox.
        /// </summary>
        [JsonPropertyName("hyperV")]
        public bool HyperV { get; set; }

        /// <summary>
        /// Obsolete: Hyper-V sandbox.
        /// </summary>
        [JsonPropertyName("isXenon")]
        public bool IsXenon { get; set; }

        /// <summary>
        /// Identity to use for Key Vault Reference authentication.
        /// </summary>
        [JsonPropertyName("keyVaultReferenceIdentity")]
        public string KeyVaultReferenceIdentity { get; set; }

        /// <summary>
        /// Property to allow or block all public traffic. Allowed Values: 'Enabled', 'Disabled' or an empty string.
        /// </summary>
        [JsonPropertyName("publicNetworkAccess")]
        public string PublicNetworkAccess { get; set; }

        /// <summary>
        /// Site redundancy mode.
        /// </summary>
        [JsonPropertyName("redundancyMode")]
        public string RedundancyMode { get; set; }

        /// <summary>
        /// <code>true</code> if reserved; otherwise, <code>false</code>.
        /// </summary>
        [JsonPropertyName("reserved")]
        public bool Reserved { get; set; }

        /// <summary>
        /// <code>true</code> to stop SCM (KUDU) site when the app is stopped; otherwise, <code>false</code>. The default is <code>false</code>.
        /// </summary>
        [JsonPropertyName("scmSiteAlsoStopped")]
        public bool ScmSiteAlsoStopped { get; set; }

        /// <summary>
        /// Resource ID of the associated App Service plan, formatted as: "/subscriptions/{subscriptionID}/resourceGroups/{groupName}/providers/Microsoft.Web/serverfarms/{appServicePlanName}".
        /// </summary>
        [JsonPropertyName("serverFarmId")]
        public string ServerFarmId { get; set; }

        /// <summary>
        /// Configuration of an App Service app.
        /// </summary>
        [JsonPropertyName("siteConfig")]
        public SiteConfig SiteConfig { get; set; }

        /// <summary>
        /// Checks if Customer provided storage account is required
        /// </summary>
        [JsonPropertyName("storageAccountRequired")]
        public bool StorageAccountRequired { get; set; }

        /// <summary>
        /// Azure Resource Manager ID of the Virtual network and subnet to be joined by Regional VNET Integration.
        [JsonPropertyName("virtualNetworkSubnetId")]
        public string VirtualNetworkSubnetId { get; set; }

        /// <summary>
        /// To enable accessing content over virtual network
        /// </summary>
        [JsonPropertyName("vnetContentShareEnabled")]
        public bool VnetContentShareEnabled { get; set; }

        /// <summary>
        /// To enable pulling image over Virtual Network
        /// </summary>
        [JsonPropertyName("vnetImagePullEnabled")]
        public bool VnetImagePullEnabled { get; set; }

        /// <summary>
        /// Virtual Network Route All enabled. This causes all outbound traffic to have Virtual Network Security Groups and User Defined Routes applied.
        /// </summary>
        [JsonPropertyName("vnetRouteAllEnabled")]
        public bool VnetRouteAllEnabled { get; set; }
    }
}