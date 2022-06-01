// Licensed under the MIT License.  See LICENSE in the project root for license information.

using System;
using System.CodeDom.Compiler;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using AzureDesignStudio.AzureResources.Base;

namespace AzureDesignStudio.AzureResources.Compute
{
    /// <summary>
    /// Describes the properties of a gallery Application Definition.
    /// </summary>
    [GeneratedCode("ArmTypeGenerator", "0.1.8.0")]
    public partial class GalleryApplicationProperties
    {
        /// <summary>
        /// The description of this gallery Application Definition resource. This property is updatable.
        /// </summary>
        [JsonPropertyName("description")]
        public string Description { get; set; }

        /// <summary>
        /// The end of life date of the gallery Application Definition. This property can be used for decommissioning purposes. This property is updatable.
        /// </summary>
        [JsonPropertyName("endOfLifeDate")]
        public DateTime EndOfLifeDate { get; set; }

        /// <summary>
        /// The Eula agreement for the gallery Application Definition.
        /// </summary>
        [JsonPropertyName("eula")]
        public string Eula { get; set; }

        /// <summary>
        /// The privacy statement uri.
        /// </summary>
        [JsonPropertyName("privacyStatementUri")]
        public string PrivacyStatementUri { get; set; }

        /// <summary>
        /// The release note uri.
        /// </summary>
        [JsonPropertyName("releaseNoteUri")]
        public string ReleaseNoteUri { get; set; }

        /// <summary>
        /// This property allows you to specify the supported type of the OS that application is built for. <br><br> Possible values are: <br><br> **Windows** <br><br> **Linux**.
        /// </summary>
        [Required]
        [JsonPropertyName("supportedOSType")]
        public string SupportedOSType { get; set; }
    }
}