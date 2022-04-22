using System;
using System.CodeDom.Compiler;
using System.Text.Json.Serialization;
using AzureDesignStudio.AzureResources.Base;

namespace AzureDesignStudio.AzureResources.Network
{
    /// <summary>
    /// Properties of the rule group.
    /// </summary>
    [GeneratedCode("Microsoft.Json.Schema.ToDotNet", "1.1.3.0")]
    public partial class VirtualApplianceSiteProperties
    {
        /// <summary>
        /// Address Prefix.
        /// </summary>
        [JsonPropertyName("addressPrefix")]
        public string AddressPrefix { get; set; }

        /// <summary>
        /// Office 365 Policy.
        /// </summary>
        [JsonPropertyName("o365Policy")]
        public Office365PolicyProperties O365Policy { get; set; }
    }
}