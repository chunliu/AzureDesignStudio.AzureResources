// Licensed under the MIT License.  See LICENSE in the project root for license information.

using System;
using System.CodeDom.Compiler;
using System.Text.Json.Serialization;
using AzureDesignStudio.AzureResources.Base;

namespace AzureDesignStudio.AzureResources.ApiManagement
{
    [GeneratedCode("ArmTypeGenerator", "0.1.8.0")]
    public partial class PortalConfigDelegationProperties
    {
        /// <summary>
        /// Enable or disable delegation for user registration.
        /// </summary>
        [JsonPropertyName("delegateRegistration")]
        public bool DelegateRegistration { get; set; }

        /// <summary>
        /// Enable or disable delegation for product subscriptions.
        /// </summary>
        [JsonPropertyName("delegateSubscription")]
        public bool DelegateSubscription { get; set; }

        /// <summary>
        /// A delegation endpoint URL.
        /// </summary>
        [JsonPropertyName("delegationUrl")]
        public string DelegationUrl { get; set; }

        /// <summary>
        /// A base64-encoded validation key to ensure requests originate from Azure API Management service.
        /// </summary>
        [JsonPropertyName("validationKey")]
        public string ValidationKey { get; set; }
    }
}