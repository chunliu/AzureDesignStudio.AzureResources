// Licensed under the MIT License.  See LICENSE in the project root for license information.

using System;
using System.CodeDom.Compiler;
using System.Text.Json.Serialization;
using AzureDesignStudio.AzureResources.Base;

namespace AzureDesignStudio.AzureResources.Web
{
    /// <summary>
    /// The configuration settings of the registration for the Apple provider
    /// </summary>
    [GeneratedCode("ArmTypeGenerator", "0.1.8.0")]
    public partial class AppleRegistration
    {
        /// <summary>
        /// The Client ID of the app used for login.
        /// </summary>
        [JsonPropertyName("clientId")]
        public string ClientId { get; set; }

        /// <summary>
        /// The app setting name that contains the client secret.
        /// </summary>
        [JsonPropertyName("clientSecretSettingName")]
        public string ClientSecretSettingName { get; set; }
    }
}