using System;
using System.CodeDom.Compiler;
using System.Text.Json.Serialization;
using AzureDesignStudio.AzureResources.Base;

namespace AzureDesignStudio.AzureResources.Storage
{
    /// <summary>
    /// Management policy action for snapshot.
    /// </summary>
    [GeneratedCode("Microsoft.Json.Schema.ToDotNet", "1.1.3.0")]
    public partial class ManagementPolicySnapShot
    {
        /// <summary>
        /// Object to define the number of days after creation.
        /// </summary>
        [JsonPropertyName("delete")]
        public DateAfterCreation Delete { get; set; }

        /// <summary>
        /// Object to define the number of days after creation.
        /// </summary>
        [JsonPropertyName("tierToArchive")]
        public DateAfterCreation TierToArchive { get; set; }

        /// <summary>
        /// Object to define the number of days after creation.
        /// </summary>
        [JsonPropertyName("tierToCool")]
        public DateAfterCreation TierToCool { get; set; }
    }
}