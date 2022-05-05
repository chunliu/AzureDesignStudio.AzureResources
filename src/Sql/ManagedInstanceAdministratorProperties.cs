// Licensed under the MIT License.  See LICENSE in the project root for license information.

using System;
using System.CodeDom.Compiler;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using AzureDesignStudio.AzureResources.Base;

namespace AzureDesignStudio.AzureResources.Sql
{
    /// <summary>
    /// The properties of a managed instance administrator.
    /// </summary>
    [GeneratedCode("ArmTypeGenerator", "0.1.8.0")]
    public partial class ManagedInstanceAdministratorProperties
    {
        /// <summary>
        /// Type of the managed instance administrator.
        /// </summary>
        [Required]
        [JsonPropertyName("administratorType")]
        public string AdministratorType { get; set; }

        /// <summary>
        /// Login name of the managed instance administrator.
        /// </summary>
        [Required]
        [JsonPropertyName("login")]
        public string Login { get; set; }

        /// <summary>
        /// SID (object ID) of the managed instance administrator.
        /// </summary>
        [Required]
        [JsonPropertyName("sid")]
        public string Sid { get; set; }

        /// <summary>
        /// Tenant ID of the managed instance administrator.
        /// </summary>
        [JsonPropertyName("tenantId")]
        public string TenantId { get; set; }
    }
}