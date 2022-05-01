using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using AzureDesignStudio.AzureResources.Base;

namespace AzureDesignStudio.AzureResources.Web
{
    /// <summary>
    /// The configuration settings of each of the identity providers used to configure App Service Authentication/Authorization.
    /// </summary>
    [GeneratedCode("Microsoft.Json.Schema.ToDotNet", "1.1.3.0")]
    public partial class IdentityProviders
    {
        /// <summary>
        /// The configuration settings of the Apple provider.
        /// </summary>
        [JsonPropertyName("apple")]
        public Apple Apple { get; set; }

        /// <summary>
        /// The configuration settings of the Azure Active directory provider.
        /// </summary>
        [JsonPropertyName("azureActiveDirectory")]
        public AzureActiveDirectory AzureActiveDirectory { get; set; }

        /// <summary>
        /// The configuration settings of the Azure Static Web Apps provider.
        /// </summary>
        [JsonPropertyName("azureStaticWebApps")]
        public AzureStaticWebApps AzureStaticWebApps { get; set; }

        /// <summary>
        /// The map of the name of the alias of each custom Open ID Connect provider to the
        [JsonPropertyName("customOpenIdConnectProviders")]
        public IDictionary<string, object> CustomOpenIdConnectProviders { get; set; }

        /// <summary>
        /// The configuration settings of the Facebook provider.
        /// </summary>
        [JsonPropertyName("facebook")]
        public Facebook Facebook { get; set; }

        /// <summary>
        /// The configuration settings of the GitHub provider.
        /// </summary>
        [JsonPropertyName("gitHub")]
        public GitHub GitHub { get; set; }

        /// <summary>
        /// The configuration settings of the Google provider.
        /// </summary>
        [JsonPropertyName("google")]
        public Google Google { get; set; }

        /// <summary>
        /// The configuration settings of the legacy Microsoft Account provider.
        /// </summary>
        [JsonPropertyName("legacyMicrosoftAccount")]
        public LegacyMicrosoftAccount LegacyMicrosoftAccount { get; set; }

        /// <summary>
        /// The configuration settings of the Twitter provider.
        /// </summary>
        [JsonPropertyName("twitter")]
        public Twitter Twitter { get; set; }
    }
}