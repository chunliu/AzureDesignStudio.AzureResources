// Licensed under the MIT License.  See LICENSE in the project root for license information.

using System;
using System.CodeDom.Compiler;
using System.Text.Json.Serialization;
using AzureDesignStudio.AzureResources.Base;

namespace AzureDesignStudio.AzureResources.Web
{
    /// <summary>
    /// The configuration settings of the Apple provider.
    /// </summary>
    [GeneratedCode("ArmTypeGenerator", "0.1.8.0")]
    public partial class Apple
    {
        /// <summary>
        /// <code>false</code> if the Apple provider should not be enabled despite the set registration; otherwise, <code>true</code>.
        /// </summary>
        [JsonPropertyName("enabled")]
        public bool Enabled { get; set; }

        /// <summary>
        /// The configuration settings of the login flow, including the scopes that should be requested.
        /// </summary>
        [JsonPropertyName("login")]
        public LoginScopes Login { get; set; }

        /// <summary>
        /// The configuration settings of the registration for the Apple provider
        /// </summary>
        [JsonPropertyName("registration")]
        public AppleRegistration Registration { get; set; }
    }
}