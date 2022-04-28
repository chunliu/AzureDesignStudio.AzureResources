using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using AzureDesignStudio.AzureResources.Base;

namespace AzureDesignStudio.AzureResources.Sql
{
    /// <summary>
    /// Azure Active Directory identity configuration for a resource.
    /// </summary>
    [GeneratedCode("Microsoft.Json.Schema.ToDotNet", "1.1.3.0")]
    public partial class ResourceIdentity
    {
        /// <summary>
        /// The identity type. Set this to 'SystemAssigned' in order to automatically create and assign an Azure Active Directory principal for the resource.
        /// </summary>
        [JsonPropertyName("type")]
        public string Type { get; set; }

        /// <summary>
        /// The resource ids of the user assigned identities to use
        /// </summary>
        [JsonPropertyName("userAssignedIdentities")]
        public IDictionary<string, object> UserAssignedIdentities { get; set; }
    }
}