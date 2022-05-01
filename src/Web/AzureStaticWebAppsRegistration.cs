using System;
using System.CodeDom.Compiler;
using System.Text.Json.Serialization;
using AzureDesignStudio.AzureResources.Base;

namespace AzureDesignStudio.AzureResources.Web
{
    /// <summary>
    /// The configuration settings of the registration for the Azure Static Web Apps provider
    /// </summary>
    [GeneratedCode("Microsoft.Json.Schema.ToDotNet", "1.1.3.0")]
    public partial class AzureStaticWebAppsRegistration
    {
        /// <summary>
        /// The Client ID of the app used for login.
        /// </summary>
        [JsonPropertyName("clientId")]
        public string ClientId { get; set; }
    }
}