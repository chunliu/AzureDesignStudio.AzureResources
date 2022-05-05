// Licensed under the MIT License.  See LICENSE in the project root for license information.

using System;
using System.CodeDom.Compiler;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using AzureDesignStudio.AzureResources.Base;

namespace AzureDesignStudio.AzureResources.Web
{
    /// <summary>
    /// Microsoft.Web/sites/slots/functions/keys
    /// </summary>
    [GeneratedCode("ArmTypeGenerator", "0.1.8.0")]
    public partial class SitesSlotsFunctionsKeys : ResourceBase
    {
        [Required]
        [JsonPropertyName("apiVersion")]
        public override string ApiVersion => "2021-02-01";

        [Required]
        [JsonPropertyName("type")]
        public override string Type => "Microsoft.Web/sites/slots/functions/keys";

        /// <summary>
        /// Key value
        /// </summary>
        [JsonPropertyName("value")]
        public string Value { get; set; }
    }
}