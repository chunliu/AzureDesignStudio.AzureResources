// Licensed under the MIT License.  See LICENSE in the project root for license information.

using System;
using System.CodeDom.Compiler;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using AzureDesignStudio.AzureResources.Base;

namespace AzureDesignStudio.AzureResources.Compute
{
    [GeneratedCode("ArmTypeGenerator", "0.1.8.0")]
    public partial class UserArtifactManage
    {
        /// <summary>
        /// Required. The path and arguments to install the gallery application. This is limited to 4096 characters.
        /// </summary>
        [Required]
        [JsonPropertyName("install")]
        public string Install { get; set; }

        /// <summary>
        /// Required. The path and arguments to remove the gallery application. This is limited to 4096 characters.
        /// </summary>
        [Required]
        [JsonPropertyName("remove")]
        public string Remove { get; set; }

        /// <summary>
        /// Optional. The path and arguments to update the gallery application. If not present, then update operation will invoke remove command on the previous version and install command on the current version of the gallery application. This is limited to 4096 characters.
        /// </summary>
        [JsonPropertyName("update")]
        public string Update { get; set; }
    }
}