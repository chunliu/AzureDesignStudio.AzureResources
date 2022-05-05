// Licensed under the MIT License.  See LICENSE in the project root for license information.

using System;
using System.CodeDom.Compiler;
using System.Text.Json.Serialization;
using AzureDesignStudio.AzureResources.Base;

namespace AzureDesignStudio.AzureResources.Web
{
    /// <summary>
    /// The configuration settings of the app registration for providers that have app ids and app secrets
    /// </summary>
    [GeneratedCode("ArmTypeGenerator", "0.1.8.0")]
    public partial class AppRegistration
    {
        /// <summary>
        /// The App ID of the app used for login.
        /// </summary>
        [JsonPropertyName("appId")]
        public string AppId { get; set; }

        /// <summary>
        /// The app setting name that contains the app secret.
        /// </summary>
        [JsonPropertyName("appSecretSettingName")]
        public string AppSecretSettingName { get; set; }
    }
}