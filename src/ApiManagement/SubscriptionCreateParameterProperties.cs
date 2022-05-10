// Licensed under the MIT License.  See LICENSE in the project root for license information.

using System;
using System.CodeDom.Compiler;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using AzureDesignStudio.AzureResources.Base;

namespace AzureDesignStudio.AzureResources.ApiManagement
{
    /// <summary>
    /// Parameters supplied to the Create subscription operation.
    /// </summary>
    [GeneratedCode("ArmTypeGenerator", "0.1.8.0")]
    public partial class SubscriptionCreateParameterProperties
    {
        /// <summary>
        /// Determines whether tracing can be enabled
        /// </summary>
        [JsonPropertyName("allowTracing")]
        public bool AllowTracing { get; set; }

        /// <summary>
        /// Subscription name.
        /// </summary>
        [Required]
        [JsonPropertyName("displayName")]
        public string DisplayName { get; set; }

        /// <summary>
        /// User (user id path) for whom subscription is being created in form /users/{userId}
        /// </summary>
        [JsonPropertyName("ownerId")]
        public string OwnerId { get; set; }

        /// <summary>
        /// Primary subscription key. If not specified during request key will be generated automatically.
        /// </summary>
        [JsonPropertyName("primaryKey")]
        public string PrimaryKey { get; set; }

        /// <summary>
        /// Scope like /products/{productId} or /apis or /apis/{apiId}.
        /// </summary>
        [Required]
        [JsonPropertyName("scope")]
        public string Scope { get; set; }

        /// <summary>
        /// Secondary subscription key. If not specified during request key will be generated automatically.
        /// </summary>
        [JsonPropertyName("secondaryKey")]
        public string SecondaryKey { get; set; }

        /// <summary>
        /// Initial subscription state. If no value is specified, subscription is created with Submitted state. Possible states are * active – the subscription is active, * suspended – the subscription is blocked, and the subscriber cannot call any APIs of the product, * submitted – the subscription request has been made by the developer, but has not yet been approved or rejected, * rejected – the subscription request has been denied by an administrator, * cancelled – the subscription has been cancelled by the developer or administrator, * expired – the subscription reached its expiration date and was deactivated.
        /// </summary>
        [JsonPropertyName("state")]
        public string State { get; set; }
    }
}