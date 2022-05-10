// Licensed under the MIT License.  See LICENSE in the project root for license information.

using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using AzureDesignStudio.AzureResources.Base;

namespace AzureDesignStudio.AzureResources.ApiManagement
{
    /// <summary>
    /// Email Template Update Contract properties.
    /// </summary>
    [GeneratedCode("ArmTypeGenerator", "0.1.8.0")]
    public partial class EmailTemplateUpdateParameterProperties
    {
        /// <summary>
        /// Email Template Body. This should be a valid XDocument
        /// </summary>
        [JsonPropertyName("body")]
        public string Body { get; set; }

        /// <summary>
        /// Description of the Email Template.
        /// </summary>
        [JsonPropertyName("description")]
        public string Description { get; set; }

        /// <summary>
        /// Email Template Parameter values.
        /// </summary>
        [JsonPropertyName("parameters")]
        public IList<EmailTemplateParametersContractProperties> Parameters { get; set; }

        /// <summary>
        /// Subject of the Template.
        /// </summary>
        [JsonPropertyName("subject")]
        public string Subject { get; set; }

        /// <summary>
        /// Title of the Template.
        /// </summary>
        [JsonPropertyName("title")]
        public string Title { get; set; }
    }
}