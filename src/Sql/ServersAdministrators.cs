// Licensed under the MIT License.  See LICENSE in the project root for license information.

using System;
using System.CodeDom.Compiler;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using AzureDesignStudio.AzureResources.Base;

namespace AzureDesignStudio.AzureResources.Sql
{
    /// <summary>
    /// Microsoft.Sql/servers/administrators
    /// </summary>
    [GeneratedCode("ArmTypeGenerator", "0.1.8.0")]
    public partial class ServersAdministrators : ResourceBase
    {
        [Required]
        [JsonPropertyName("apiVersion")]
        public override string ApiVersion => "2021-02-01-preview";

        /// <summary>
        /// Properties of a active directory administrator.
        /// </summary>
        [Required]
        [JsonPropertyName("properties")]
        public AdministratorProperties Properties { get; set; }

        [Required]
        [JsonPropertyName("type")]
        public override string Type => "Microsoft.Sql/servers/administrators";
    }
}