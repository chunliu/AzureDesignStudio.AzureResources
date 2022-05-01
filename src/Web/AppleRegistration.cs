using System;
using System.CodeDom.Compiler;
using System.Text.Json.Serialization;
using AzureDesignStudio.AzureResources.Base;

namespace AzureDesignStudio.AzureResources.Web
{
    /// <summary>
    /// The configuration settings of the registration for the Apple provider
    /// </summary>
    [GeneratedCode("Microsoft.Json.Schema.ToDotNet", "1.1.3.0")]
    public partial class AppleRegistration
    {
        /// <summary>
        /// The Client ID of the app used for login.
        /// </summary>
        [JsonPropertyName("clientId")]
        public string ClientId { get; set; }

        /// <summary>
        /// The app setting name that contains the client secret.
        /// </summary>
        [JsonPropertyName("clientSecretSettingName")]
        public string ClientSecretSettingName { get; set; }
    }
}