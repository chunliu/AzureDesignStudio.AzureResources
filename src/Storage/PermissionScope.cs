// Licensed under the MIT License.  See LICENSE in the project root for license information.

using System;
using System.CodeDom.Compiler;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using AzureDesignStudio.AzureResources.Base;

namespace AzureDesignStudio.AzureResources.Storage
{
    [GeneratedCode("ArmTypeGenerator", "0.1.8.0")]
    public partial class PermissionScope
    {
        /// <summary>
        /// The permissions for the local user. Possible values include: Read (r), Write (w), Delete (d), List (l), and Create (c).
        /// </summary>
        [Required]
        [JsonPropertyName("permissions")]
        public string Permissions { get; set; }

        /// <summary>
        /// The name of resource, normally the container name or the file share name, used by the local user.
        /// </summary>
        [Required]
        [JsonPropertyName("resourceName")]
        public string ResourceName { get; set; }

        /// <summary>
        /// The service used by the local user, e.g. blob, file.
        /// </summary>
        [Required]
        [JsonPropertyName("service")]
        public string Service { get; set; }
    }
}