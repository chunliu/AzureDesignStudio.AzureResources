// Licensed under the MIT License.  See LICENSE in the project root for license information.

using System;
using System.CodeDom.Compiler;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using AzureDesignStudio.AzureResources.Base;

namespace AzureDesignStudio.AzureResources.Sql
{
    /// <summary>
    /// Microsoft.Sql/instancePools
    /// </summary>
    [GeneratedCode("ArmTypeGenerator", "0.1.8.0")]
    public partial class InstancePools : ResourceBase
    {
        [Required]
        [JsonPropertyName("apiVersion")]
        public override string ApiVersion => "2022-02-01-preview";

        /// <summary>
        /// Properties of an instance pool.
        /// </summary>
        [Required]
        [JsonPropertyName("properties")]
        public InstancePoolProperties Properties { get; set; }

        /// <summary>
        /// An ARM Resource SKU.
        /// </summary>
        [JsonPropertyName("sku")]
        public Sku Sku { get; set; }

        [Required]
        [JsonPropertyName("type")]
        public override string Type => "Microsoft.Sql/instancePools";
    }
}