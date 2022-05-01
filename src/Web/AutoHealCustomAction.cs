using System;
using System.CodeDom.Compiler;
using System.Text.Json.Serialization;
using AzureDesignStudio.AzureResources.Base;

namespace AzureDesignStudio.AzureResources.Web
{
    /// <summary>
    /// Custom action to be executed
    [GeneratedCode("Microsoft.Json.Schema.ToDotNet", "1.1.3.0")]
    public partial class AutoHealCustomAction
    {
        /// <summary>
        /// Executable to be run.
        /// </summary>
        [JsonPropertyName("exe")]
        public string Exe { get; set; }

        /// <summary>
        /// Parameters for the executable.
        /// </summary>
        [JsonPropertyName("parameters")]
        public string Parameters { get; set; }
    }
}