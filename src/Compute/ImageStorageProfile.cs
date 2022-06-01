// Licensed under the MIT License.  See LICENSE in the project root for license information.

using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using AzureDesignStudio.AzureResources.Base;

namespace AzureDesignStudio.AzureResources.Compute
{
    /// <summary>
    /// Describes a storage profile.
    /// </summary>
    [GeneratedCode("ArmTypeGenerator", "0.1.8.0")]
    public partial class ImageStorageProfile
    {
        /// <summary>
        /// Specifies the parameters that are used to add a data disk to a virtual machine. <br><br> For more information about disks, see [About disks and VHDs for Azure virtual machines](https://docs.microsoft.com/azure/virtual-machines/managed-disks-overview).
        /// </summary>
        [JsonPropertyName("dataDisks")]
        public IList<ImageDataDisk> DataDisks { get; set; }

        /// <summary>
        /// Describes an Operating System disk.
        /// </summary>
        [JsonPropertyName("osDisk")]
        public ImageOSDisk OsDisk { get; set; }

        /// <summary>
        /// Specifies whether an image is zone resilient or not. Default is false. Zone resilient images can be created only in regions that provide Zone Redundant Storage (ZRS).
        /// </summary>
        [JsonPropertyName("zoneResilient")]
        public bool ZoneResilient { get; set; }
    }
}