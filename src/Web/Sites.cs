// Licensed under the MIT License.  See LICENSE in the project root for license information.

using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using AzureDesignStudio.AzureResources.Base;

namespace AzureDesignStudio.AzureResources.Web
{
    /// <summary>
    /// Microsoft.Web/sites
    /// </summary>
    [GeneratedCode("ArmTypeGenerator", "0.1.8.0")]
    public partial class Sites : ResourceBase
    {
        [Required]
        [JsonPropertyName("apiVersion")]
        public override string ApiVersion => "2022-03-01";

        /// <summary>
        /// Extended Location.
        /// </summary>
        [JsonPropertyName("extendedLocation")]
        public ExtendedLocation ExtendedLocation { get; set; }

        /// <summary>
        /// Managed service identity.
        /// </summary>
        [JsonPropertyName("identity")]
        public ManagedServiceIdentity Identity { get; set; }

        /// <summary>
        /// Kind of resource.
        /// </summary>
        [JsonPropertyName("kind")]
        public string Kind { get; set; }

        /// <summary>
        /// Site resource specific properties
        /// </summary>
        [Required]
        [JsonPropertyName("properties")]
        public SiteProperties Properties { get; set; }
        [JsonPropertyName("resources")]
        public IList<ResourceBase> Resources { get; set; }

        [Required]
        [JsonPropertyName("type")]
        public override string Type => "Microsoft.Web/sites";
    }
}