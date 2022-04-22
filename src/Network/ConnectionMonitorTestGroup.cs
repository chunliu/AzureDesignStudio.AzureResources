using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using AzureDesignStudio.AzureResources.Base;

namespace AzureDesignStudio.AzureResources.Network
{
    /// <summary>
    /// Describes the connection monitor test group.
    /// </summary>
    [GeneratedCode("Microsoft.Json.Schema.ToDotNet", "1.1.3.0")]
    public partial class ConnectionMonitorTestGroup
    {
        /// <summary>
        /// The name of the connection monitor test group.
        /// </summary>
        [Required]
        [JsonPropertyName("name")]
        public string Name { get; set; }

        /// <summary>
        /// Value indicating whether test group is disabled.
        /// </summary>
        [JsonPropertyName("disable")]
        public bool Disable { get; set; }

        /// <summary>
        /// List of test configuration names.
        /// </summary>
        [Required]
        [JsonPropertyName("testConfigurations")]
        public IList<string> TestConfigurations { get; set; }

        /// <summary>
        /// List of source endpoint names.
        /// </summary>
        [Required]
        [JsonPropertyName("sources")]
        public IList<string> Sources { get; set; }

        /// <summary>
        /// List of destination endpoint names.
        /// </summary>
        [Required]
        [JsonPropertyName("destinations")]
        public IList<string> Destinations { get; set; }
    }
}