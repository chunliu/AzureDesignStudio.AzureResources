// Licensed under the MIT License.  See LICENSE in the project root for license information.

using System;
using System.CodeDom.Compiler;
using System.Text.Json.Serialization;
using AzureDesignStudio.AzureResources.Base;

namespace AzureDesignStudio.AzureResources.ApiManagement
{
    /// <summary>
    /// Properties specific to the Backend Type.
    /// </summary>
    [GeneratedCode("ArmTypeGenerator", "0.1.8.0")]
    public partial class BackendProperties
    {
        /// <summary>
        /// Properties of the Service Fabric Type Backend.
        /// </summary>
        [JsonPropertyName("serviceFabricCluster")]
        public BackendServiceFabricClusterProperties ServiceFabricCluster { get; set; }
    }
}