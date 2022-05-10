// Licensed under the MIT License.  See LICENSE in the project root for license information.

using System;
using System.CodeDom.Compiler;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using AzureDesignStudio.AzureResources.Base;

namespace AzureDesignStudio.AzureResources.ApiManagement
{
    /// <summary>
    /// Issue Attachment contract Properties.
    /// </summary>
    [GeneratedCode("ArmTypeGenerator", "0.1.8.0")]
    public partial class IssueAttachmentContractProperties
    {
        /// <summary>
        /// An HTTP link or Base64-encoded binary data.
        /// </summary>
        [Required]
        [JsonPropertyName("content")]
        public string Content { get; set; }

        /// <summary>
        /// Either 'link' if content is provided via an HTTP link or the MIME type of the Base64-encoded binary data provided in the 'content' property.
        /// </summary>
        [Required]
        [JsonPropertyName("contentFormat")]
        public string ContentFormat { get; set; }

        /// <summary>
        /// Filename by which the binary data will be saved.
        /// </summary>
        [Required]
        [JsonPropertyName("title")]
        public string Title { get; set; }
    }
}