// Licensed under the MIT License.  See LICENSE in the project root for license information.

using System;
using System.CodeDom.Compiler;
using System.Text.Json.Serialization;
using AzureDesignStudio.AzureResources.Base;

namespace AzureDesignStudio.AzureResources.ApiManagement
{
    /// <summary>
    /// Terms of service contract properties.
    /// </summary>
    [GeneratedCode("ArmTypeGenerator", "0.1.8.0")]
    public partial class PortalConfigTermsOfServiceProperties
    {
        /// <summary>
        /// Ask user for consent to the terms of service.
        /// </summary>
        [JsonPropertyName("requireConsent")]
        public bool RequireConsent { get; set; }

        /// <summary>
        /// A terms of service text.
        /// </summary>
        [JsonPropertyName("text")]
        public string Text { get; set; }
    }
}