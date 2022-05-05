// Licensed under the MIT License.  See LICENSE in the project root for license information.

using System;
using System.CodeDom.Compiler;
using System.Text.Json.Serialization;
using AzureDesignStudio.AzureResources.Base;

namespace AzureDesignStudio.AzureResources.Web
{
    /// <summary>
    /// The authentication client credentials of the custom Open ID Connect provider.
    /// </summary>
    [GeneratedCode("ArmTypeGenerator", "0.1.8.0")]
    public partial class OpenIdConnectClientCredential
    {
        /// <summary>
        /// The app setting that contains the client secret for the custom Open ID Connect provider.
        /// </summary>
        [JsonPropertyName("clientSecretSettingName")]
        public string ClientSecretSettingName { get; set; }

        /// <summary>
        /// The method that should be used to authenticate the user.
        /// </summary>
        [JsonPropertyName("method")]
        public string Method { get; set; }
    }
}