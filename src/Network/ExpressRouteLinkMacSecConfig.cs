using System;
using System.CodeDom.Compiler;
using System.Text.Json.Serialization;
using AzureDesignStudio.AzureResources.Base;

namespace AzureDesignStudio.AzureResources.Network
{
    /// <summary>
    /// ExpressRouteLink Mac Security Configuration.
    /// </summary>
    [GeneratedCode("Microsoft.Json.Schema.ToDotNet", "1.1.3.0")]
    public partial class ExpressRouteLinkMacSecConfig
    {
        /// <summary>
        /// Keyvault Secret Identifier URL containing Mac security CKN key.
        /// </summary>
        [JsonPropertyName("cknSecretIdentifier")]
        public string CknSecretIdentifier { get; set; }

        /// <summary>
        /// Keyvault Secret Identifier URL containing Mac security CAK key.
        /// </summary>
        [JsonPropertyName("cakSecretIdentifier")]
        public string CakSecretIdentifier { get; set; }

        /// <summary>
        /// Mac security cipher.
        /// </summary>
        [JsonPropertyName("cipher")]
        public string Cipher { get; set; }

        /// <summary>
        /// Sci mode enabled/disabled.
        /// </summary>
        [JsonPropertyName("sciState")]
        public string SciState { get; set; }
    }
}