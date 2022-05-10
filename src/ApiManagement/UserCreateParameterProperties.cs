// Licensed under the MIT License.  See LICENSE in the project root for license information.

using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using AzureDesignStudio.AzureResources.Base;

namespace AzureDesignStudio.AzureResources.ApiManagement
{
    /// <summary>
    /// Parameters supplied to the Create User operation.
    /// </summary>
    [GeneratedCode("ArmTypeGenerator", "0.1.8.0")]
    public partial class UserCreateParameterProperties
    {
        /// <summary>
        /// Determines the type of application which send the create user request. Default is legacy portal.
        /// </summary>
        [JsonPropertyName("appType")]
        public string AppType { get; set; }

        /// <summary>
        /// Determines the type of confirmation e-mail that will be sent to the newly created user.
        /// </summary>
        [JsonPropertyName("confirmation")]
        public string Confirmation { get; set; }

        /// <summary>
        /// Email address. Must not be empty and must be unique within the service instance.
        /// </summary>
        [Required]
        [JsonPropertyName("email")]
        public string Email { get; set; }

        /// <summary>
        /// First name.
        /// </summary>
        [Required]
        [JsonPropertyName("firstName")]
        public string FirstName { get; set; }

        /// <summary>
        /// Collection of user identities.
        /// </summary>
        [JsonPropertyName("identities")]
        public IList<UserIdentityContract> Identities { get; set; }

        /// <summary>
        /// Last name.
        /// </summary>
        [Required]
        [JsonPropertyName("lastName")]
        public string LastName { get; set; }

        /// <summary>
        /// Optional note about a user set by the administrator.
        /// </summary>
        [JsonPropertyName("note")]
        public string Note { get; set; }

        /// <summary>
        /// User Password. If no value is provided, a default password is generated.
        /// </summary>
        [JsonPropertyName("password")]
        public string Password { get; set; }

        /// <summary>
        /// Account state. Specifies whether the user is active or not. Blocked users are unable to sign into the developer portal or call any APIs of subscribed products. Default state is Active.
        /// </summary>
        [JsonPropertyName("state")]
        public string State { get; set; }
    }
}