// Licensed under the MIT License.  See LICENSE in the project root for license information.

using System;
using System.CodeDom.Compiler;
using System.Text.Json.Serialization;
using AzureDesignStudio.AzureResources.Base;

namespace AzureDesignStudio.AzureResources.Web
{
    /// <summary>
    /// The configuration settings of the app registration for the Twitter provider.
    /// </summary>
    [GeneratedCode("ArmTypeGenerator", "0.1.8.0")]
    public partial class TwitterRegistration
    {
        /// <summary>
        /// The OAuth 1.0a consumer key of the Twitter application used for sign-in.
        [JsonPropertyName("consumerKey")]
        public string ConsumerKey { get; set; }

        /// <summary>
        /// The app setting name that contains the OAuth 1.0a consumer secret of the Twitter
        [JsonPropertyName("consumerSecretSettingName")]
        public string ConsumerSecretSettingName { get; set; }
    }
}