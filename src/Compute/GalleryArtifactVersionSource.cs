// Licensed under the MIT License.  See LICENSE in the project root for license information.

using System;
using System.CodeDom.Compiler;
using System.Text.Json.Serialization;
using AzureDesignStudio.AzureResources.Base;

namespace AzureDesignStudio.AzureResources.Compute
{
    /// <summary>
    /// The gallery artifact version source.
    /// </summary>
    [GeneratedCode("ArmTypeGenerator", "0.1.8.0")]
    public partial class GalleryArtifactVersionSource
    {
        /// <summary>
        /// The id of the gallery artifact version source. Can specify a disk uri, snapshot uri, user image or storage account resource.
        /// </summary>
        [JsonPropertyName("id")]
        public string Id { get; set; }

        /// <summary>
        /// The uri of the gallery artifact version source. Currently used to specify vhd/blob source.
        /// </summary>
        [JsonPropertyName("uri")]
        public string Uri { get; set; }
    }
}