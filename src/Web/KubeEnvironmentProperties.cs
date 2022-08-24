// Licensed under the MIT License.  See LICENSE in the project root for license information.

using System;
using System.CodeDom.Compiler;
using System.Text.Json.Serialization;
using AzureDesignStudio.AzureResources.Base;

namespace AzureDesignStudio.AzureResources.Web
{
    /// <summary>
    /// KubeEnvironment resource specific properties
    /// </summary>
    [GeneratedCode("ArmTypeGenerator", "0.1.8.0")]
    public partial class KubeEnvironmentProperties
    {
        [JsonPropertyName("aksResourceID")]
        public string AksResourceID { get; set; }
        [JsonPropertyName("appLogsConfiguration")]
        public AppLogsConfiguration AppLogsConfiguration { get; set; }
        [JsonPropertyName("arcConfiguration")]
        public ArcConfiguration ArcConfiguration { get; set; }
        [JsonPropertyName("containerAppsConfiguration")]
        public ContainerAppsConfiguration ContainerAppsConfiguration { get; set; }

        /// <summary>
        /// Type of Kubernetes Environment. Only supported for Container App Environments with value as Managed
        /// </summary>
        [JsonPropertyName("environmentType")]
        public string EnvironmentType { get; set; }

        /// <summary>
        /// Only visible within Vnet/Subnet
        /// </summary>
        [JsonPropertyName("internalLoadBalancerEnabled")]
        public bool InternalLoadBalancerEnabled { get; set; }

        /// <summary>
        /// Static IP of the KubeEnvironment
        /// </summary>
        [JsonPropertyName("staticIp")]
        public string StaticIp { get; set; }
    }
}