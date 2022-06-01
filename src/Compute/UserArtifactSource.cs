// Licensed under the MIT License.  See LICENSE in the project root for license information.

using System;
using System.CodeDom.Compiler;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using AzureDesignStudio.AzureResources.Base;

namespace AzureDesignStudio.AzureResources.Compute
{
    /// <summary>
    /// The source image from which the Image Version is going to be created.
    /// </summary>
    [GeneratedCode("ArmTypeGenerator", "0.1.8.0")]
    public partial class UserArtifactSource
    {
        /// <summary>
        /// Optional. The defaultConfigurationLink of the artifact, must be a readable storage page blob.
        /// </summary>
        [JsonPropertyName("defaultConfigurationLink")]
        public string DefaultConfigurationLink { get; set; }

        /// <summary>
        /// Required. The mediaLink of the artifact, must be a readable storage page blob.
        /// </summary>
        [Required]
        [JsonPropertyName("mediaLink")]
        public string MediaLink { get; set; }
    }
}