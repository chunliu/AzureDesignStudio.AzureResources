// Licensed under the MIT License.  See LICENSE in the project root for license information.

using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using AzureDesignStudio.AzureResources.Base;

namespace AzureDesignStudio.AzureResources.ApiManagement
{
    /// <summary>
    /// Properties of the Service Fabric Type Backend.
    /// </summary>
    [GeneratedCode("ArmTypeGenerator", "0.1.8.0")]
    public partial class BackendServiceFabricClusterProperties
    {
        /// <summary>
        /// The client certificate id for the management endpoint.
        /// </summary>
        [JsonPropertyName("clientCertificateId")]
        public string ClientCertificateId { get; set; }

        /// <summary>
        /// The client certificate thumbprint for the management endpoint. Will be ignored if certificatesIds are provided
        /// </summary>
        [JsonPropertyName("clientCertificatethumbprint")]
        public string ClientCertificatethumbprint { get; set; }

        /// <summary>
        /// The cluster management endpoint.
        /// </summary>
        [Required]
        [JsonPropertyName("managementEndpoints")]
        public IList<string> ManagementEndpoints { get; set; }

        /// <summary>
        /// Maximum number of retries while attempting resolve the partition.
        /// </summary>
        [JsonPropertyName("maxPartitionResolutionRetries")]
        public int MaxPartitionResolutionRetries { get; set; }

        /// <summary>
        /// Thumbprints of certificates cluster management service uses for tls communication
        /// </summary>
        [JsonPropertyName("serverCertificateThumbprints")]
        public IList<string> ServerCertificateThumbprints { get; set; }

        /// <summary>
        /// Server X509 Certificate Names Collection
        /// </summary>
        [JsonPropertyName("serverX509Names")]
        public IList<X509CertificateName> ServerX509Names { get; set; }
    }
}