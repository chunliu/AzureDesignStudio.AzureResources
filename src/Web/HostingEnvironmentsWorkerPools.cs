// Licensed under the MIT License.  See LICENSE in the project root for license information.

using System;
using System.CodeDom.Compiler;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using AzureDesignStudio.AzureResources.Base;

namespace AzureDesignStudio.AzureResources.Web
{
    /// <summary>
    /// Microsoft.Web/hostingEnvironments/workerPools
    /// </summary>
    [GeneratedCode("ArmTypeGenerator", "0.1.8.0")]
    public partial class HostingEnvironmentsWorkerPools : ResourceBase
    {
        [Required]
        [JsonPropertyName("apiVersion")]
        public override string ApiVersion => "2022-03-01";

        /// <summary>
        /// Kind of resource.
        /// </summary>
        [JsonPropertyName("kind")]
        public string Kind { get; set; }

        /// <summary>
        /// Worker pool of an App Service Environment.
        /// </summary>
        [Required]
        [JsonPropertyName("properties")]
        public WorkerPool Properties { get; set; }

        /// <summary>
        /// Description of a SKU for a scalable resource.
        /// </summary>
        [JsonPropertyName("sku")]
        public SkuDescription Sku { get; set; }

        [Required]
        [JsonPropertyName("type")]
        public override string Type => "Microsoft.Web/hostingEnvironments/workerPools";
    }
}