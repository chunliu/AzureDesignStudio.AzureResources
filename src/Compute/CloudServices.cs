// Licensed under the MIT License.  See LICENSE in the project root for license information.

using System;
using System.CodeDom.Compiler;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using AzureDesignStudio.AzureResources.Base;

namespace AzureDesignStudio.AzureResources.Compute
{
    /// <summary>
    /// Microsoft.Compute/cloudServices
    /// </summary>
    [GeneratedCode("ArmTypeGenerator", "0.1.8.0")]
    public partial class CloudServices : ResourceBase
    {
        [Required]
        [JsonPropertyName("apiVersion")]
        public override string ApiVersion => "2022-04-04";

        /// <summary>
        /// Cloud service properties
        /// </summary>
        [Required]
        [JsonPropertyName("properties")]
        public CloudServiceProperties Properties { get; set; }

        /// <summary>
        /// The system meta data relating to this resource.
        /// </summary>
        [JsonPropertyName("systemData")]
        public SystemData SystemData { get; set; }

        [Required]
        [JsonPropertyName("type")]
        public override string Type => "Microsoft.Compute/cloudServices";
    }
}