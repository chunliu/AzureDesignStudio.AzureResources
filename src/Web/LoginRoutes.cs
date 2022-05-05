// Licensed under the MIT License.  See LICENSE in the project root for license information.

using System;
using System.CodeDom.Compiler;
using System.Text.Json.Serialization;
using AzureDesignStudio.AzureResources.Base;

namespace AzureDesignStudio.AzureResources.Web
{
    /// <summary>
    /// The routes that specify the endpoints used for login and logout requests.
    /// </summary>
    [GeneratedCode("ArmTypeGenerator", "0.1.8.0")]
    public partial class LoginRoutes
    {
        /// <summary>
        /// The endpoint at which a logout request should be made.
        /// </summary>
        [JsonPropertyName("logoutEndpoint")]
        public string LogoutEndpoint { get; set; }
    }
}