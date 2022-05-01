using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using AzureDesignStudio.AzureResources.Base;

namespace AzureDesignStudio.AzureResources.Web
{
    /// <summary>
    /// Configuration of an App Service app.
    /// </summary>
    [GeneratedCode("Microsoft.Json.Schema.ToDotNet", "1.1.3.0")]
    public partial class SiteConfig
    {
        /// <summary>
        /// Flag to use Managed Identity Creds for ACR pull
        /// </summary>
        [JsonPropertyName("acrUseManagedIdentityCreds")]
        public bool AcrUseManagedIdentityCreds { get; set; }

        /// <summary>
        /// If using user managed identity, the user managed identity ClientId
        /// </summary>
        [JsonPropertyName("acrUserManagedIdentityID")]
        public string AcrUserManagedIdentityID { get; set; }

        /// <summary>
        /// <code>true</code> if Always On is enabled; otherwise, <code>false</code>.
        /// </summary>
        [JsonPropertyName("alwaysOn")]
        public bool AlwaysOn { get; set; }

        /// <summary>
        /// Information about the formal API definition for the app.
        /// </summary>
        [JsonPropertyName("apiDefinition")]
        public ApiDefinitionInfo ApiDefinition { get; set; }

        /// <summary>
        /// Azure API management (APIM) configuration linked to the app.
        /// </summary>
        [JsonPropertyName("apiManagementConfig")]
        public ApiManagementConfig ApiManagementConfig { get; set; }

        /// <summary>
        /// App command line to launch.
        /// </summary>
        [JsonPropertyName("appCommandLine")]
        public string AppCommandLine { get; set; }

        /// <summary>
        /// Application settings.
        /// </summary>
        [JsonPropertyName("appSettings")]
        public IList<NameValuePair> AppSettings { get; set; }

        /// <summary>
        /// <code>true</code> if Auto Heal is enabled; otherwise, <code>false</code>.
        /// </summary>
        [JsonPropertyName("autoHealEnabled")]
        public bool AutoHealEnabled { get; set; }

        /// <summary>
        /// Rules that can be defined for auto-heal.
        /// </summary>
        [JsonPropertyName("autoHealRules")]
        public AutoHealRules AutoHealRules { get; set; }

        /// <summary>
        /// Auto-swap slot name.
        /// </summary>
        [JsonPropertyName("autoSwapSlotName")]
        public string AutoSwapSlotName { get; set; }

        /// <summary>
        /// List of Azure Storage Accounts.
        /// </summary>
        [JsonPropertyName("azureStorageAccounts")]
        public IDictionary<string, object> AzureStorageAccounts { get; set; }

        /// <summary>
        /// Connection strings.
        /// </summary>
        [JsonPropertyName("connectionStrings")]
        public IList<ConnStringInfo> ConnectionStrings { get; set; }

        /// <summary>
        /// Cross-Origin Resource Sharing (CORS) settings for the app.
        /// </summary>
        [JsonPropertyName("cors")]
        public CorsSettings Cors { get; set; }

        /// <summary>
        /// Default documents.
        /// </summary>
        [JsonPropertyName("defaultDocuments")]
        public IList<string> DefaultDocuments { get; set; }

        /// <summary>
        /// <code>true</code> if detailed error logging is enabled; otherwise, <code>false</code>.
        /// </summary>
        [JsonPropertyName("detailedErrorLoggingEnabled")]
        public bool DetailedErrorLoggingEnabled { get; set; }

        /// <summary>
        /// Document root.
        /// </summary>
        [JsonPropertyName("documentRoot")]
        public string DocumentRoot { get; set; }

        /// <summary>
        /// Routing rules in production experiments.
        /// </summary>
        [JsonPropertyName("experiments")]
        public Experiments Experiments { get; set; }

        /// <summary>
        /// State of FTP / FTPS service.
        /// </summary>
        [JsonPropertyName("ftpsState")]
        public string FtpsState { get; set; }

        /// <summary>
        /// Maximum number of workers that a site can scale out to.
        [JsonPropertyName("functionAppScaleLimit")]
        public int FunctionAppScaleLimit { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether functions runtime scale monitoring is enabled. When enabled,
        [JsonPropertyName("functionsRuntimeScaleMonitoringEnabled")]
        public bool FunctionsRuntimeScaleMonitoringEnabled { get; set; }

        /// <summary>
        /// Handler mappings.
        /// </summary>
        [JsonPropertyName("handlerMappings")]
        public IList<HandlerMapping> HandlerMappings { get; set; }

        /// <summary>
        /// Health check path
        /// </summary>
        [JsonPropertyName("healthCheckPath")]
        public string HealthCheckPath { get; set; }

        /// <summary>
        /// Http20Enabled: configures a web site to allow clients to connect over http2.0
        /// </summary>
        [JsonPropertyName("http20Enabled")]
        public bool Http20Enabled { get; set; }

        /// <summary>
        /// <code>true</code> if HTTP logging is enabled; otherwise, <code>false</code>.
        /// </summary>
        [JsonPropertyName("httpLoggingEnabled")]
        public bool HttpLoggingEnabled { get; set; }

        /// <summary>
        /// IP security restrictions for main.
        /// </summary>
        [JsonPropertyName("ipSecurityRestrictions")]
        public IList<IpSecurityRestriction> IpSecurityRestrictions { get; set; }

        /// <summary>
        /// Java container.
        /// </summary>
        [JsonPropertyName("javaContainer")]
        public string JavaContainer { get; set; }

        /// <summary>
        /// Java container version.
        /// </summary>
        [JsonPropertyName("javaContainerVersion")]
        public string JavaContainerVersion { get; set; }

        /// <summary>
        /// Java version.
        /// </summary>
        [JsonPropertyName("javaVersion")]
        public string JavaVersion { get; set; }

        /// <summary>
        /// Identity to use for Key Vault Reference authentication.
        /// </summary>
        [JsonPropertyName("keyVaultReferenceIdentity")]
        public string KeyVaultReferenceIdentity { get; set; }

        /// <summary>
        /// Metric limits set on an app.
        /// </summary>
        [JsonPropertyName("limits")]
        public SiteLimits Limits { get; set; }

        /// <summary>
        /// Linux App Framework and version
        /// </summary>
        [JsonPropertyName("linuxFxVersion")]
        public string LinuxFxVersion { get; set; }

        /// <summary>
        /// Site load balancing.
        /// </summary>
        [JsonPropertyName("loadBalancing")]
        public string LoadBalancing { get; set; }

        /// <summary>
        /// <code>true</code> to enable local MySQL; otherwise, <code>false</code>.
        /// </summary>
        [JsonPropertyName("localMySqlEnabled")]
        public bool LocalMySqlEnabled { get; set; }

        /// <summary>
        /// HTTP logs directory size limit.
        /// </summary>
        [JsonPropertyName("logsDirectorySizeLimit")]
        public int LogsDirectorySizeLimit { get; set; }

        /// <summary>
        /// Managed pipeline mode.
        /// </summary>
        [JsonPropertyName("managedPipelineMode")]
        public string ManagedPipelineMode { get; set; }

        /// <summary>
        /// Managed Service Identity Id
        /// </summary>
        [JsonPropertyName("managedServiceIdentityId")]
        public int ManagedServiceIdentityId { get; set; }

        /// <summary>
        /// Number of minimum instance count for a site
        [JsonPropertyName("minimumElasticInstanceCount")]
        public int MinimumElasticInstanceCount { get; set; }

        /// <summary>
        /// MinTlsVersion: configures the minimum version of TLS required for SSL requests.
        /// </summary>
        [JsonPropertyName("minTlsVersion")]
        public string MinTlsVersion { get; set; }

        /// <summary>
        /// .NET Framework version.
        /// </summary>
        [JsonPropertyName("netFrameworkVersion")]
        public string NetFrameworkVersion { get; set; }

        /// <summary>
        /// Version of Node.js.
        /// </summary>
        [JsonPropertyName("nodeVersion")]
        public string NodeVersion { get; set; }

        /// <summary>
        /// Number of workers.
        /// </summary>
        [JsonPropertyName("numberOfWorkers")]
        public int NumberOfWorkers { get; set; }

        /// <summary>
        /// Version of PHP.
        /// </summary>
        [JsonPropertyName("phpVersion")]
        public string PhpVersion { get; set; }

        /// <summary>
        /// Version of PowerShell.
        /// </summary>
        [JsonPropertyName("powerShellVersion")]
        public string PowerShellVersion { get; set; }

        /// <summary>
        /// Number of preWarmed instances.
        [JsonPropertyName("preWarmedInstanceCount")]
        public int PreWarmedInstanceCount { get; set; }

        /// <summary>
        /// Property to allow or block all public traffic.
        /// </summary>
        [JsonPropertyName("publicNetworkAccess")]
        public string PublicNetworkAccess { get; set; }

        /// <summary>
        /// Publishing user name.
        /// </summary>
        [JsonPropertyName("publishingUsername")]
        public string PublishingUsername { get; set; }

        /// <summary>
        /// Push settings for the App.
        /// </summary>
        [JsonPropertyName("push")]
        public PushSettings Push { get; set; }

        /// <summary>
        /// Version of Python.
        /// </summary>
        [JsonPropertyName("pythonVersion")]
        public string PythonVersion { get; set; }

        /// <summary>
        /// <code>true</code> if remote debugging is enabled; otherwise, <code>false</code>.
        /// </summary>
        [JsonPropertyName("remoteDebuggingEnabled")]
        public bool RemoteDebuggingEnabled { get; set; }

        /// <summary>
        /// Remote debugging version.
        /// </summary>
        [JsonPropertyName("remoteDebuggingVersion")]
        public string RemoteDebuggingVersion { get; set; }

        /// <summary>
        /// <code>true</code> if request tracing is enabled; otherwise, <code>false</code>.
        /// </summary>
        [JsonPropertyName("requestTracingEnabled")]
        public bool RequestTracingEnabled { get; set; }

        /// <summary>
        /// Request tracing expiration time.
        /// </summary>
        [JsonPropertyName("requestTracingExpirationTime")]
        public DateTime RequestTracingExpirationTime { get; set; }

        /// <summary>
        /// IP security restrictions for scm.
        /// </summary>
        [JsonPropertyName("scmIpSecurityRestrictions")]
        public IList<IpSecurityRestriction> ScmIpSecurityRestrictions { get; set; }

        /// <summary>
        /// IP security restrictions for scm to use main.
        /// </summary>
        [JsonPropertyName("scmIpSecurityRestrictionsUseMain")]
        public bool ScmIpSecurityRestrictionsUseMain { get; set; }

        /// <summary>
        /// ScmMinTlsVersion: configures the minimum version of TLS required for SSL requests for SCM site.
        /// </summary>
        [JsonPropertyName("scmMinTlsVersion")]
        public string ScmMinTlsVersion { get; set; }

        /// <summary>
        /// SCM type.
        /// </summary>
        [JsonPropertyName("scmType")]
        public string ScmType { get; set; }

        /// <summary>
        /// Tracing options.
        /// </summary>
        [JsonPropertyName("tracingOptions")]
        public string TracingOptions { get; set; }

        /// <summary>
        /// <code>true</code> to use 32-bit worker process; otherwise, <code>false</code>.
        /// </summary>
        [JsonPropertyName("use32BitWorkerProcess")]
        public bool Use32BitWorkerProcess { get; set; }

        /// <summary>
        /// Virtual applications.
        /// </summary>
        [JsonPropertyName("virtualApplications")]
        public IList<VirtualApplication> VirtualApplications { get; set; }

        /// <summary>
        /// Virtual Network name.
        /// </summary>
        [JsonPropertyName("vnetName")]
        public string VnetName { get; set; }

        /// <summary>
        /// The number of private ports assigned to this app. These will be assigned dynamically on runtime.
        /// </summary>
        [JsonPropertyName("vnetPrivatePortsCount")]
        public int VnetPrivatePortsCount { get; set; }

        /// <summary>
        /// Virtual Network Route All enabled. This causes all outbound traffic to have Virtual Network Security Groups and User Defined Routes applied.
        /// </summary>
        [JsonPropertyName("vnetRouteAllEnabled")]
        public bool VnetRouteAllEnabled { get; set; }

        /// <summary>
        /// Sets the time zone a site uses for generating timestamps. Compatible with Linux and Windows App Service. Setting the WEBSITE_TIME_ZONE app setting takes precedence over this config. For Linux, expects tz database values https://www.iana.org/time-zones (for a quick reference see https://en.wikipedia.org/wiki/List_of_tz_database_time_zones). For Windows, expects one of the time zones listed under HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows NT\CurrentVersion\Time Zones
        /// </summary>
        [JsonPropertyName("websiteTimeZone")]
        public string WebsiteTimeZone { get; set; }

        /// <summary>
        /// <code>true</code> if WebSocket is enabled; otherwise, <code>false</code>.
        /// </summary>
        [JsonPropertyName("webSocketsEnabled")]
        public bool WebSocketsEnabled { get; set; }

        /// <summary>
        /// Xenon App Framework and version
        /// </summary>
        [JsonPropertyName("windowsFxVersion")]
        public string WindowsFxVersion { get; set; }

        /// <summary>
        /// Explicit Managed Service Identity Id
        /// </summary>
        [JsonPropertyName("xManagedServiceIdentityId")]
        public int XManagedServiceIdentityId { get; set; }
    }
}