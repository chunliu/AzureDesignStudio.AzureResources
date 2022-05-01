using System;
using System.CodeDom.Compiler;
using System.Text.Json.Serialization;
using AzureDesignStudio.AzureResources.Base;

namespace AzureDesignStudio.AzureResources.Web
{
    /// <summary>
    /// The configuration settings of the platform of App Service Authentication/Authorization.
    /// </summary>
    [GeneratedCode("Microsoft.Json.Schema.ToDotNet", "1.1.3.0")]
    public partial class AuthPlatform
    {
        /// <summary>
        /// The path of the config file containing auth settings if they come from a file.
        [JsonPropertyName("configFilePath")]
        public string ConfigFilePath { get; set; }

        /// <summary>
        /// <code>true</code> if the Authentication / Authorization feature is enabled for the current app; otherwise, <code>false</code>.
        /// </summary>
        [JsonPropertyName("enabled")]
        public bool Enabled { get; set; }

        /// <summary>
        /// The RuntimeVersion of the Authentication / Authorization feature in use for the current app.
        [JsonPropertyName("runtimeVersion")]
        public string RuntimeVersion { get; set; }
    }
}