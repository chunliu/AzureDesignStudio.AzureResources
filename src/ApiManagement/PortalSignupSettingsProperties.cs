// Licensed under the MIT License.  See LICENSE in the project root for license information.

using System;
using System.CodeDom.Compiler;
using System.Text.Json.Serialization;
using AzureDesignStudio.AzureResources.Base;

namespace AzureDesignStudio.AzureResources.ApiManagement
{
    /// <summary>
    /// Sign-up settings contract properties.
    /// </summary>
    [GeneratedCode("ArmTypeGenerator", "0.1.8.0")]
    public partial class PortalSignupSettingsProperties
    {
        /// <summary>
        /// Allow users to sign up on a developer portal.
        /// </summary>
        [JsonPropertyName("enabled")]
        public bool Enabled { get; set; }

        /// <summary>
        /// Terms of service contract properties.
        /// </summary>
        [JsonPropertyName("termsOfService")]
        public TermsOfServiceProperties TermsOfService { get; set; }
    }
}