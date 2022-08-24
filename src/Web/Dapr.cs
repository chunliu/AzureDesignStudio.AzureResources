// Licensed under the MIT License.  See LICENSE in the project root for license information.

using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using AzureDesignStudio.AzureResources.Base;

namespace AzureDesignStudio.AzureResources.Web
{
    /// <summary>
    /// Container App Dapr configuration.
    /// </summary>
    [GeneratedCode("ArmTypeGenerator", "0.1.8.0")]
    public partial class Dapr
    {
        /// <summary>
        /// Dapr application identifier
        /// </summary>
        [JsonPropertyName("appId")]
        public string AppId { get; set; }

        /// <summary>
        /// Port on which the Dapr side car
        /// </summary>
        [JsonPropertyName("appPort")]
        public int AppPort { get; set; }

        /// <summary>
        /// Collection of Dapr components
        /// </summary>
        [JsonPropertyName("components")]
        public IList<DaprComponent> Components { get; set; }

        /// <summary>
        /// Boolean indicating if the Dapr side car is enabled
        /// </summary>
        [JsonPropertyName("enabled")]
        public bool Enabled { get; set; }
    }
}