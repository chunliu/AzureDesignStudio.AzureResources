// Licensed under the MIT License.  See LICENSE in the project root for license information.

using System;
using System.CodeDom.Compiler;
using System.Text.Json.Serialization;
using AzureDesignStudio.AzureResources.Base;

namespace AzureDesignStudio.AzureResources.ApiManagement
{
    /// <summary>
    /// Delegation settings contract properties.
    /// </summary>
    [GeneratedCode("ArmTypeGenerator", "0.1.8.0")]
    public partial class PortalDelegationSettingsProperties
    {
        /// <summary>
        /// Subscriptions delegation settings properties.
        /// </summary>
        [JsonPropertyName("subscriptions")]
        public SubscriptionsDelegationSettingsProperties Subscriptions { get; set; }

        /// <summary>
        /// A delegation Url.
        /// </summary>
        [JsonPropertyName("url")]
        public string Url { get; set; }

        /// <summary>
        /// User registration delegation settings properties.
        /// </summary>
        [JsonPropertyName("userRegistration")]
        public RegistrationDelegationSettingsProperties UserRegistration { get; set; }

        /// <summary>
        /// A base64-encoded validation key to validate, that a request is coming from Azure API Management.
        /// </summary>
        [JsonPropertyName("validationKey")]
        public string ValidationKey { get; set; }
    }
}