using System;
using System.CodeDom.Compiler;
using System.Text.Json.Serialization;
using AzureDesignStudio.AzureResources.Base;

namespace AzureDesignStudio.AzureResources.Storage
{
    /// <summary>
    /// The properties of an ImmutabilityPolicy of a blob container.
    /// </summary>
    [GeneratedCode("Microsoft.Json.Schema.ToDotNet", "1.1.3.0")]
    public partial class ImmutabilityPolicyProperty
    {
        /// <summary>
        /// This property can only be changed for unlocked time-based retention policies. When enabled, new blocks can be written to an append blob while maintaining immutability protection and compliance. Only new blocks can be added and any existing blocks cannot be modified or deleted. This property cannot be changed with ExtendImmutabilityPolicy API.
        /// </summary>
        [JsonPropertyName("allowProtectedAppendWrites")]
        public bool AllowProtectedAppendWrites { get; set; }

        /// <summary>
        /// This property can only be changed for unlocked time-based retention policies. When enabled, new blocks can be written to both 'Append and Bock Blobs' while maintaining immutability protection and compliance. Only new blocks can be added and any existing blocks cannot be modified or deleted. This property cannot be changed with ExtendImmutabilityPolicy API. The 'allowProtectedAppendWrites' and 'allowProtectedAppendWritesAll' properties are mutually exclusive.
        /// </summary>
        [JsonPropertyName("allowProtectedAppendWritesAll")]
        public bool AllowProtectedAppendWritesAll { get; set; }

        /// <summary>
        /// The immutability period for the blobs in the container since the policy creation, in days.
        /// </summary>
        [JsonPropertyName("immutabilityPeriodSinceCreationInDays")]
        public int ImmutabilityPeriodSinceCreationInDays { get; set; }
    }
}