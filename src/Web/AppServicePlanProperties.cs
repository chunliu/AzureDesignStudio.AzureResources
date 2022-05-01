using System;
using System.CodeDom.Compiler;
using System.Text.Json.Serialization;
using AzureDesignStudio.AzureResources.Base;

namespace AzureDesignStudio.AzureResources.Web
{
    /// <summary>
    /// AppServicePlan resource specific properties
    /// </summary>
    [GeneratedCode("Microsoft.Json.Schema.ToDotNet", "1.1.3.0")]
    public partial class AppServicePlanProperties
    {
        /// <summary>
        /// ServerFarm supports ElasticScale. Apps in this plan will scale as if the ServerFarm was ElasticPremium sku
        /// </summary>
        [JsonPropertyName("elasticScaleEnabled")]
        public bool ElasticScaleEnabled { get; set; }

        /// <summary>
        /// The time when the server farm free offer expires.
        /// </summary>
        [JsonPropertyName("freeOfferExpirationTime")]
        public DateTime FreeOfferExpirationTime { get; set; }

        /// <summary>
        /// Specification for an App Service Environment to use for this resource.
        /// </summary>
        [JsonPropertyName("hostingEnvironmentProfile")]
        public HostingEnvironmentProfile HostingEnvironmentProfile { get; set; }

        /// <summary>
        /// If Hyper-V container app service plan <code>true</code>, <code>false</code> otherwise.
        /// </summary>
        [JsonPropertyName("hyperV")]
        public bool HyperV { get; set; }

        /// <summary>
        /// If <code>true</code>, this App Service Plan owns spot instances.
        /// </summary>
        [JsonPropertyName("isSpot")]
        public bool IsSpot { get; set; }

        /// <summary>
        /// Obsolete: If Hyper-V container app service plan <code>true</code>, <code>false</code> otherwise.
        /// </summary>
        [JsonPropertyName("isXenon")]
        public bool IsXenon { get; set; }

        /// <summary>
        /// Specification for a Kubernetes Environment to use for this resource.
        /// </summary>
        [JsonPropertyName("kubeEnvironmentProfile")]
        public KubeEnvironmentProfile KubeEnvironmentProfile { get; set; }

        /// <summary>
        /// Maximum number of total workers allowed for this ElasticScaleEnabled App Service Plan
        /// </summary>
        [JsonPropertyName("maximumElasticWorkerCount")]
        public int MaximumElasticWorkerCount { get; set; }

        /// <summary>
        /// If <code>true</code>, apps assigned to this App Service plan can be scaled independently.
        [JsonPropertyName("perSiteScaling")]
        public bool PerSiteScaling { get; set; }

        /// <summary>
        /// If Linux app service plan <code>true</code>, <code>false</code> otherwise.
        /// </summary>
        [JsonPropertyName("reserved")]
        public bool Reserved { get; set; }

        /// <summary>
        /// The time when the server farm expires. Valid only if it is a spot server farm.
        /// </summary>
        [JsonPropertyName("spotExpirationTime")]
        public DateTime SpotExpirationTime { get; set; }

        /// <summary>
        /// Scaling worker count.
        /// </summary>
        [JsonPropertyName("targetWorkerCount")]
        public int TargetWorkerCount { get; set; }

        /// <summary>
        /// Scaling worker size ID.
        /// </summary>
        [JsonPropertyName("targetWorkerSizeId")]
        public int TargetWorkerSizeId { get; set; }

        /// <summary>
        /// Target worker tier assigned to the App Service plan.
        /// </summary>
        [JsonPropertyName("workerTierName")]
        public string WorkerTierName { get; set; }

        /// <summary>
        /// If <code>true</code>, this App Service Plan will perform availability zone balancing.
        [JsonPropertyName("zoneRedundant")]
        public bool ZoneRedundant { get; set; }
    }
}