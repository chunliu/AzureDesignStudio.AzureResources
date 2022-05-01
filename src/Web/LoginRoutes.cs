using System;
using System.CodeDom.Compiler;
using System.Text.Json.Serialization;
using AzureDesignStudio.AzureResources.Base;

namespace AzureDesignStudio.AzureResources.Web
{
    /// <summary>
    /// The routes that specify the endpoints used for login and logout requests.
    /// </summary>
    [GeneratedCode("Microsoft.Json.Schema.ToDotNet", "1.1.3.0")]
    public partial class LoginRoutes
    {
        /// <summary>
        /// The endpoint at which a logout request should be made.
        /// </summary>
        [JsonPropertyName("logoutEndpoint")]
        public string LogoutEndpoint { get; set; }
    }
}