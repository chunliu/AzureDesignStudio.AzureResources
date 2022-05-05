// Licensed under the MIT License.  See LICENSE in the project root for license information.

using System;
using System.CodeDom.Compiler;
using System.Text.Json.Serialization;
using AzureDesignStudio.AzureResources.Base;

namespace AzureDesignStudio.AzureResources.Web
{
    /// <summary>
    /// Description of the App Service plan scale options.
    /// </summary>
    [GeneratedCode("ArmTypeGenerator", "0.1.8.0")]
    public partial class SkuCapacity
    {
        /// <summary>
        /// Default number of workers for this App Service plan SKU.
        /// </summary>
        [JsonPropertyName("default")]
        public int Default { get; set; }

        /// <summary>
        /// Maximum number of Elastic workers for this App Service plan SKU.
        /// </summary>
        [JsonPropertyName("elasticMaximum")]
        public int ElasticMaximum { get; set; }

        /// <summary>
        /// Maximum number of workers for this App Service plan SKU.
        /// </summary>
        [JsonPropertyName("maximum")]
        public int Maximum { get; set; }

        /// <summary>
        /// Minimum number of workers for this App Service plan SKU.
        /// </summary>
        [JsonPropertyName("minimum")]
        public int Minimum { get; set; }

        /// <summary>
        /// Available scale configurations for an App Service plan.
        /// </summary>
        [JsonPropertyName("scaleType")]
        public string ScaleType { get; set; }
    }
}