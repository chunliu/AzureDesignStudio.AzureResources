using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using AzureDesignStudio.AzureResources.Base;

namespace AzureDesignStudio.AzureResources.Network
{
    /// <summary>
    /// Properties of the IpAllocation.
    /// </summary>
    [GeneratedCode("Microsoft.Json.Schema.ToDotNet", "1.1.3.0")]
    public partial class IpAllocationPropertiesFormat
    {
        /// <summary>
        /// The type for the IpAllocation.
        /// </summary>
        [JsonPropertyName("type")]
        public string Type { get; set; }

        /// <summary>
        /// The address prefix for the IpAllocation.
        /// </summary>
        [JsonPropertyName("prefix")]
        public string Prefix { get; set; }

        /// <summary>
        /// The address prefix length for the IpAllocation.
        /// </summary>
        [JsonPropertyName("prefixLength")]
        public int PrefixLength { get; set; }

        /// <summary>
        /// The address prefix Type for the IpAllocation.
        /// </summary>
        [JsonPropertyName("prefixType")]
        public string PrefixType { get; set; }

        /// <summary>
        /// The IPAM allocation ID.
        /// </summary>
        [JsonPropertyName("ipamAllocationId")]
        public string IpamAllocationId { get; set; }

        /// <summary>
        /// IpAllocation tags.
        /// </summary>
        [JsonPropertyName("allocationTags")]
        public IDictionary<string, string> AllocationTags { get; set; }
    }
}