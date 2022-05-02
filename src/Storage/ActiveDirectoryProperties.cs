using System;
using System.CodeDom.Compiler;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using AzureDesignStudio.AzureResources.Base;

namespace AzureDesignStudio.AzureResources.Storage
{
    /// <summary>
    /// Settings properties for Active Directory (AD).
    /// </summary>
    [GeneratedCode("Microsoft.Json.Schema.ToDotNet", "1.1.3.0")]
    public partial class ActiveDirectoryProperties
    {
        /// <summary>
        /// Specifies the security identifier (SID) for Azure Storage.
        /// </summary>
        [Required]
        [JsonPropertyName("azureStorageSid")]
        public string AzureStorageSid { get; set; }

        /// <summary>
        /// Specifies the domain GUID.
        /// </summary>
        [Required]
        [JsonPropertyName("domainGuid")]
        public string DomainGuid { get; set; }

        /// <summary>
        /// Specifies the primary domain that the AD DNS server is authoritative for.
        /// </summary>
        [Required]
        [JsonPropertyName("domainName")]
        public string DomainName { get; set; }

        /// <summary>
        /// Specifies the security identifier (SID).
        /// </summary>
        [Required]
        [JsonPropertyName("domainSid")]
        public string DomainSid { get; set; }

        /// <summary>
        /// Specifies the Active Directory forest to get.
        /// </summary>
        [Required]
        [JsonPropertyName("forestName")]
        public string ForestName { get; set; }

        /// <summary>
        /// Specifies the NetBIOS domain name.
        /// </summary>
        [Required]
        [JsonPropertyName("netBiosDomainName")]
        public string NetBiosDomainName { get; set; }
    }
}