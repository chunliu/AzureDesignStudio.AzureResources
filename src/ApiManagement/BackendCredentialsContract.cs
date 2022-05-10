// Licensed under the MIT License.  See LICENSE in the project root for license information.

using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using AzureDesignStudio.AzureResources.Base;

namespace AzureDesignStudio.AzureResources.ApiManagement
{
    /// <summary>
    /// Details of the Credentials used to connect to Backend.
    /// </summary>
    [GeneratedCode("ArmTypeGenerator", "0.1.8.0")]
    public partial class BackendCredentialsContract
    {
        /// <summary>
        /// Authorization header information.
        /// </summary>
        [JsonPropertyName("authorization")]
        public BackendAuthorizationHeaderCredentials Authorization { get; set; }

        /// <summary>
        /// List of Client Certificate Thumbprints. Will be ignored if certificatesIds are provided.
        /// </summary>
        [JsonPropertyName("certificate")]
        public IList<string> Certificate { get; set; }

        /// <summary>
        /// List of Client Certificate Ids.
        /// </summary>
        [JsonPropertyName("certificateIds")]
        public IList<string> CertificateIds { get; set; }

        /// <summary>
        /// Header Parameter description.
        /// </summary>
        [JsonPropertyName("header")]
        public IDictionary<string, IList<string>> Header { get; set; }

        /// <summary>
        /// Query Parameter description.
        /// </summary>
        [JsonPropertyName("query")]
        public IDictionary<string, IList<string>> Query { get; set; }
    }
}