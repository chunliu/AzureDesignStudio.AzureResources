using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using AzureDesignStudio.AzureResources.Base;

namespace AzureDesignStudio.AzureResources.Network
{
    /// <summary>
    /// Public IP address resource.
    /// </summary>
    [GeneratedCode("Microsoft.Json.Schema.ToDotNet", "1.1.3.0")]
    public partial class PublicIPAddress
    {
        /// <summary>
        /// Resource location.
        /// </summary>
        [Required]
        [JsonPropertyName("location")]
        public string Location { get; set; }

        /// <summary>
        /// Resource tags.
        /// </summary>
        [JsonPropertyName("tags")]
        public IDictionary<string, string> Tags { get; set; }

        /// <summary>
        /// The extended location of the public ip address.
        /// </summary>
        [JsonPropertyName("extendedLocation")]
        public ExtendedLocation ExtendedLocation { get; set; }

        /// <summary>
        /// The public IP address SKU.
        /// </summary>
        [JsonPropertyName("sku")]
        public PublicIPAddressSku Sku { get; set; }

        /// <summary>
        /// Public IP address properties.
        /// </summary>
        [JsonPropertyName("properties")]
        public PublicIPAddressPropertiesFormat Properties { get; set; }

        /// <summary>
        /// A list of availability zones denoting the IP allocated for the resource needs to come from.
        /// </summary>
        [JsonPropertyName("zones")]
        public IList<string> Zones { get; set; }
    }
}