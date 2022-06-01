// Licensed under the MIT License.  See LICENSE in the project root for license information.

using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using AzureDesignStudio.AzureResources.Base;

namespace AzureDesignStudio.AzureResources.Compute
{
    /// <summary>
    /// Describes a virtual machine scale set storage profile.
    /// </summary>
    [GeneratedCode("ArmTypeGenerator", "0.1.8.0")]
    public partial class VirtualMachineScaleSetStorageProfile
    {
        /// <summary>
        /// Specifies the parameters that are used to add data disks to the virtual machines in the scale set. <br><br> For more information about disks, see [About disks and VHDs for Azure virtual machines](https://docs.microsoft.com/azure/virtual-machines/managed-disks-overview).
        /// </summary>
        [JsonPropertyName("dataDisks")]
        public IList<VirtualMachineScaleSetDataDisk> DataDisks { get; set; }

        /// <summary>
        /// Specifies information about the image to use. You can specify information about platform images, marketplace images, or virtual machine images. This element is required when you want to use a platform image, marketplace image, or virtual machine image, but is not used in other creation operations. NOTE: Image reference publisher and offer can only be set when you create the scale set.
        /// </summary>
        [JsonPropertyName("imageReference")]
        public ImageReference ImageReference { get; set; }

        /// <summary>
        /// Describes a virtual machine scale set operating system disk.
        /// </summary>
        [JsonPropertyName("osDisk")]
        public VirtualMachineScaleSetOSDisk OsDisk { get; set; }
    }
}