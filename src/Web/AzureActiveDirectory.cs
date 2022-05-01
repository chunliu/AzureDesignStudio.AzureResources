using System;
using System.CodeDom.Compiler;
using System.Text.Json.Serialization;
using AzureDesignStudio.AzureResources.Base;

namespace AzureDesignStudio.AzureResources.Web
{
    /// <summary>
    /// The configuration settings of the Azure Active directory provider.
    /// </summary>
    [GeneratedCode("Microsoft.Json.Schema.ToDotNet", "1.1.3.0")]
    public partial class AzureActiveDirectory
    {
        /// <summary>
        /// <code>false</code> if the Azure Active Directory provider should not be enabled despite the set registration; otherwise, <code>true</code>.
        /// </summary>
        [JsonPropertyName("enabled")]
        public bool Enabled { get; set; }

        /// <summary>
        /// Gets a value indicating whether the Azure AD configuration was auto-provisioned using 1st party tooling.
        [JsonPropertyName("isAutoProvisioned")]
        public bool IsAutoProvisioned { get; set; }

        /// <summary>
        /// The configuration settings of the Azure Active Directory login flow.
        /// </summary>
        [JsonPropertyName("login")]
        public AzureActiveDirectoryLogin Login { get; set; }

        /// <summary>
        /// The configuration settings of the Azure Active Directory app registration.
        /// </summary>
        [JsonPropertyName("registration")]
        public AzureActiveDirectoryRegistration Registration { get; set; }

        /// <summary>
        /// The configuration settings of the Azure Active Directory token validation flow.
        /// </summary>
        [JsonPropertyName("validation")]
        public AzureActiveDirectoryValidation Validation { get; set; }
    }
}