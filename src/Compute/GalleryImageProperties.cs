// Licensed under the MIT License.  See LICENSE in the project root for license information.

using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using AzureDesignStudio.AzureResources.Base;

namespace AzureDesignStudio.AzureResources.Compute
{
    /// <summary>
    /// Describes the properties of a gallery image definition.
    /// </summary>
    [GeneratedCode("ArmTypeGenerator", "0.1.8.0")]
    public partial class GalleryImageProperties
    {
        /// <summary>
        /// The description of this gallery image definition resource. This property is updatable.
        /// </summary>
        [JsonPropertyName("description")]
        public string Description { get; set; }

        /// <summary>
        /// Describes the disallowed disk types.
        /// </summary>
        [JsonPropertyName("disallowed")]
        public Disallowed Disallowed { get; set; }

        /// <summary>
        /// The end of life date of the gallery image definition. This property can be used for decommissioning purposes. This property is updatable.
        /// </summary>
        [JsonPropertyName("endOfLifeDate")]
        public DateTime EndOfLifeDate { get; set; }

        /// <summary>
        /// The Eula agreement for the gallery image definition.
        /// </summary>
        [JsonPropertyName("eula")]
        public string Eula { get; set; }

        /// <summary>
        /// A list of gallery image features.
        /// </summary>
        [JsonPropertyName("features")]
        public IList<GalleryImageFeature> Features { get; set; }

        /// <summary>
        /// The hypervisor generation of the Virtual Machine. Applicable to OS disks only.
        /// </summary>
        [JsonPropertyName("hyperVGeneration")]
        public string HyperVGeneration { get; set; }

        /// <summary>
        /// This is the gallery image definition identifier.
        /// </summary>
        [Required]
        [JsonPropertyName("identifier")]
        public GalleryImageIdentifier Identifier { get; set; }

        /// <summary>
        /// This property allows the user to specify whether the virtual machines created under this image are 'Generalized' or 'Specialized'.
        /// </summary>
        [Required]
        [JsonPropertyName("osState")]
        public string OsState { get; set; }

        /// <summary>
        /// This property allows you to specify the type of the OS that is included in the disk when creating a VM from a managed image. <br><br> Possible values are: <br><br> **Windows** <br><br> **Linux**.
        /// </summary>
        [Required]
        [JsonPropertyName("osType")]
        public string OsType { get; set; }

        /// <summary>
        /// The privacy statement uri.
        /// </summary>
        [JsonPropertyName("privacyStatementUri")]
        public string PrivacyStatementUri { get; set; }

        /// <summary>
        /// Describes the gallery image definition purchase plan. This is used by marketplace images.
        /// </summary>
        [JsonPropertyName("purchasePlan")]
        public ImagePurchasePlan PurchasePlan { get; set; }

        /// <summary>
        /// The properties describe the recommended machine configuration for this Image Definition. These properties are updatable.
        /// </summary>
        [JsonPropertyName("recommended")]
        public RecommendedMachineConfiguration Recommended { get; set; }

        /// <summary>
        /// The release note uri.
        /// </summary>
        [JsonPropertyName("releaseNoteUri")]
        public string ReleaseNoteUri { get; set; }
    }
}