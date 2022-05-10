// Licensed under the MIT License.  See LICENSE in the project root for license information.

using System;
using System.CodeDom.Compiler;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using AzureDesignStudio.AzureResources.Base;

namespace AzureDesignStudio.AzureResources.ApiManagement
{
    /// <summary>
    /// Issue Comment contract Properties.
    /// </summary>
    [GeneratedCode("ArmTypeGenerator", "0.1.8.0")]
    public partial class IssueCommentContractProperties
    {
        /// <summary>
        /// Date and time when the comment was created.
        /// </summary>
        [JsonPropertyName("createdDate")]
        public DateTime CreatedDate { get; set; }

        /// <summary>
        /// Comment text.
        /// </summary>
        [Required]
        [JsonPropertyName("text")]
        public string Text { get; set; }

        /// <summary>
        /// A resource identifier for the user who left the comment.
        /// </summary>
        [Required]
        [JsonPropertyName("userId")]
        public string UserId { get; set; }
    }
}