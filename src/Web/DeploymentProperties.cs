// Licensed under the MIT License.  See LICENSE in the project root for license information.

using System;
using System.CodeDom.Compiler;
using System.Text.Json.Serialization;
using AzureDesignStudio.AzureResources.Base;

namespace AzureDesignStudio.AzureResources.Web
{
    /// <summary>
    /// Deployment resource specific properties
    /// </summary>
    [GeneratedCode("ArmTypeGenerator", "0.1.8.0")]
    public partial class DeploymentProperties
    {
        /// <summary>
        /// True if deployment is currently active, false if completed and null if not started.
        /// </summary>
        [JsonPropertyName("active")]
        public bool Active { get; set; }

        /// <summary>
        /// Who authored the deployment.
        /// </summary>
        [JsonPropertyName("author")]
        public string Author { get; set; }

        /// <summary>
        /// Author email.
        /// </summary>
        [JsonPropertyName("author_email")]
        public string Author_email { get; set; }

        /// <summary>
        /// Who performed the deployment.
        /// </summary>
        [JsonPropertyName("deployer")]
        public string Deployer { get; set; }

        /// <summary>
        /// Details on deployment.
        /// </summary>
        [JsonPropertyName("details")]
        public string Details { get; set; }

        /// <summary>
        /// End time.
        /// </summary>
        [JsonPropertyName("end_time")]
        public DateTime End_time { get; set; }

        /// <summary>
        /// Details about deployment status.
        /// </summary>
        [JsonPropertyName("message")]
        public string Message { get; set; }

        /// <summary>
        /// Start time.
        /// </summary>
        [JsonPropertyName("start_time")]
        public DateTime Start_time { get; set; }

        /// <summary>
        /// Deployment status.
        /// </summary>
        [JsonPropertyName("status")]
        public int Status { get; set; }
    }
}