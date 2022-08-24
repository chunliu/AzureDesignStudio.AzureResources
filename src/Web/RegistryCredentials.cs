// Licensed under the MIT License.  See LICENSE in the project root for license information.

using System;
using System.CodeDom.Compiler;
using System.Text.Json.Serialization;
using AzureDesignStudio.AzureResources.Base;

namespace AzureDesignStudio.AzureResources.Web
{
    /// <summary>
    /// Container App Private Registry
    /// </summary>
    [GeneratedCode("ArmTypeGenerator", "0.1.8.0")]
    public partial class RegistryCredentials
    {
        /// <summary>
        /// The name of the Secret that contains the registry login password
        /// </summary>
        [JsonPropertyName("passwordSecretRef")]
        public string PasswordSecretRef { get; set; }

        /// <summary>
        /// Container Registry Server
        /// </summary>
        [JsonPropertyName("server")]
        public string Server { get; set; }

        /// <summary>
        /// Container Registry Username
        /// </summary>
        [JsonPropertyName("username")]
        public string Username { get; set; }
    }
}