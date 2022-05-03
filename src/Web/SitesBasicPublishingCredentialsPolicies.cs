using System;
using System.CodeDom.Compiler;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using AzureDesignStudio.AzureResources.Base;

namespace AzureDesignStudio.AzureResources.Web
{
    /// <summary>
    /// Microsoft.Web/sites/basicPublishingCredentialsPolicies
    /// </summary>
    [GeneratedCode("Microsoft.Json.Schema.ToDotNet", "1.1.3.0")]
    public partial class SitesBasicPublishingCredentialsPolicies : ResourceBase
    {
        [Required]
        [JsonPropertyName("apiVersion")]
        public override string ApiVersion => "2021-02-01";

        [Required]
        [JsonPropertyName("type")]
        public override string Type => "Microsoft.Web/sites/basicPublishingCredentialsPolicies";

        /// <summary>
        /// Kind of resource.
        /// </summary>
        [JsonPropertyName("kind")]
        public string Kind { get; set; }

        /// <summary>
        /// CsmPublishingCredentialsPoliciesEntity resource specific properties
        /// </summary>
        [Required]
        [JsonPropertyName("properties")]
        public CsmPublishingCredentialsPoliciesEntityProperties Properties { get; set; }
    }
}