using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using AzureDesignStudio.AzureResources.Base;

namespace AzureDesignStudio.AzureResources.Web
{
    /// <summary>
    /// The configuration settings of the Allowed Audiences validation flow.
    /// </summary>
    [GeneratedCode("Microsoft.Json.Schema.ToDotNet", "1.1.3.0")]
    public partial class AllowedAudiencesValidation
    {
        /// <summary>
        /// The configuration settings of the allowed list of audiences from which to validate the JWT token.
        /// </summary>
        [JsonPropertyName("allowedAudiences")]
        public IList<string> AllowedAudiences { get; set; }
    }
}