// Licensed under the MIT License.  See LICENSE in the project root for license information.

using System;
using System.CodeDom.Compiler;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using AzureDesignStudio.AzureResources.Base;

namespace AzureDesignStudio.AzureResources.ApiManagement
{
    /// <summary>
    /// Microsoft.ApiManagement/service/apis/issues/comments
    /// </summary>
    [GeneratedCode("ArmTypeGenerator", "0.1.8.0")]
    public partial class ServiceApisIssuesComments : ResourceBase
    {
        [Required]
        [JsonPropertyName("apiVersion")]
        public override string ApiVersion => "2021-04-01-preview";

        /// <summary>
        /// Issue Comment contract Properties.
        /// </summary>
        [Required]
        [JsonPropertyName("properties")]
        public IssueCommentContractProperties Properties { get; set; }

        [Required]
        [JsonPropertyName("type")]
        public override string Type => "Microsoft.ApiManagement/service/apis/issues/comments";
    }
}