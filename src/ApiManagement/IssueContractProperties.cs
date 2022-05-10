// Licensed under the MIT License.  See LICENSE in the project root for license information.

using System;
using System.CodeDom.Compiler;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using AzureDesignStudio.AzureResources.Base;

namespace AzureDesignStudio.AzureResources.ApiManagement
{
    /// <summary>
    /// Issue contract Properties.
    /// </summary>
    [GeneratedCode("ArmTypeGenerator", "0.1.8.0")]
    public partial class IssueContractProperties
    {
        /// <summary>
        /// A resource identifier for the API the issue was created for.
        /// </summary>
        [JsonPropertyName("apiId")]
        public string ApiId { get; set; }

        /// <summary>
        /// Date and time when the issue was created.
        /// </summary>
        [JsonPropertyName("createdDate")]
        public DateTime CreatedDate { get; set; }

        /// <summary>
        /// Text describing the issue.
        /// </summary>
        [Required]
        [JsonPropertyName("description")]
        public string Description { get; set; }

        /// <summary>
        /// Status of the issue.
        /// </summary>
        [JsonPropertyName("state")]
        public string State { get; set; }

        /// <summary>
        /// The issue title.
        /// </summary>
        [Required]
        [JsonPropertyName("title")]
        public string Title { get; set; }

        /// <summary>
        /// A resource identifier for the user created the issue.
        /// </summary>
        [Required]
        [JsonPropertyName("userId")]
        public string UserId { get; set; }
    }
}