// Licensed under the MIT License.  See LICENSE in the project root for license information.

using System;
using System.CodeDom.Compiler;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using AzureDesignStudio.AzureResources.Base;

namespace AzureDesignStudio.AzureResources.Sql
{
    /// <summary>
    /// Microsoft.Sql/servers/databases/extensions
    /// </summary>
    [GeneratedCode("ArmTypeGenerator", "0.1.8.0")]
    public partial class ServersDatabasesExtensions : ResourceBase
    {
        [Required]
        [JsonPropertyName("apiVersion")]
        public override string ApiVersion => "2022-02-01-preview";

        /// <summary>
        /// Contains the database information after a successful Import, Export, or PolybaseImport
        /// </summary>
        [Required]
        [JsonPropertyName("properties")]
        public DatabaseExtensionsProperties Properties { get; set; }

        [Required]
        [JsonPropertyName("type")]
        public override string Type => "Microsoft.Sql/servers/databases/extensions";
    }
}