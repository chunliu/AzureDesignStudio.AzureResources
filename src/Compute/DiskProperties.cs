// Licensed under the MIT License.  See LICENSE in the project root for license information.

using System;
using System.CodeDom.Compiler;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using AzureDesignStudio.AzureResources.Base;

namespace AzureDesignStudio.AzureResources.Compute
{
    /// <summary>
    /// Disk resource properties.
    /// </summary>
    [GeneratedCode("ArmTypeGenerator", "0.1.8.0")]
    public partial class DiskProperties
    {
        /// <summary>
        /// Set to true to enable bursting beyond the provisioned performance target of the disk. Bursting is disabled by default. Does not apply to Ultra disks.
        /// </summary>
        [JsonPropertyName("burstingEnabled")]
        public bool BurstingEnabled { get; set; }

        /// <summary>
        /// Percentage complete for the background copy when a resource is created via the CopyStart operation.
        /// </summary>
        [JsonPropertyName("completionPercent")]
        public double CompletionPercent { get; set; }

        /// <summary>
        /// Data used when creating a disk.
        /// </summary>
        [Required]
        [JsonPropertyName("creationData")]
        public CreationData CreationData { get; set; }
        [JsonPropertyName("dataAccessAuthMode")]
        public string DataAccessAuthMode { get; set; }

        /// <summary>
        /// ARM id of the DiskAccess resource for using private endpoints on disks.
        /// </summary>
        [JsonPropertyName("diskAccessId")]
        public string DiskAccessId { get; set; }

        /// <summary>
        /// The total number of IOPS that will be allowed across all VMs mounting the shared disk as ReadOnly. One operation can transfer between 4k and 256k bytes.
        /// </summary>
        [JsonPropertyName("diskIOPSReadOnly")]
        public int DiskIOPSReadOnly { get; set; }

        /// <summary>
        /// The number of IOPS allowed for this disk; only settable for UltraSSD disks. One operation can transfer between 4k and 256k bytes.
        /// </summary>
        [JsonPropertyName("diskIOPSReadWrite")]
        public int DiskIOPSReadWrite { get; set; }

        /// <summary>
        /// The total throughput (MBps) that will be allowed across all VMs mounting the shared disk as ReadOnly. MBps means millions of bytes per second - MB here uses the ISO notation, of powers of 10.
        /// </summary>
        [JsonPropertyName("diskMBpsReadOnly")]
        public int DiskMBpsReadOnly { get; set; }

        /// <summary>
        /// The bandwidth allowed for this disk; only settable for UltraSSD disks. MBps means millions of bytes per second - MB here uses the ISO notation, of powers of 10.
        /// </summary>
        [JsonPropertyName("diskMBpsReadWrite")]
        public int DiskMBpsReadWrite { get; set; }

        /// <summary>
        /// If creationData.createOption is Empty, this field is mandatory and it indicates the size of the disk to create. If this field is present for updates or creation with other options, it indicates a resize. Resizes are only allowed if the disk is not attached to a running VM, and can only increase the disk's size.
        /// </summary>
        [JsonPropertyName("diskSizeGB")]
        public int DiskSizeGB { get; set; }

        /// <summary>
        /// The state of the disk.
        /// </summary>
        [JsonPropertyName("diskState")]
        public string DiskState { get; set; }

        /// <summary>
        /// Encryption at rest settings for disk or snapshot
        /// </summary>
        [JsonPropertyName("encryption")]
        public Encryption Encryption { get; set; }

        /// <summary>
        /// Encryption settings for disk or snapshot
        /// </summary>
        [JsonPropertyName("encryptionSettingsCollection")]
        public EncryptionSettingsCollection EncryptionSettingsCollection { get; set; }

        /// <summary>
        /// The hypervisor generation of the Virtual Machine. Applicable to OS disks only.
        /// </summary>
        [JsonPropertyName("hyperVGeneration")]
        public string HyperVGeneration { get; set; }

        /// <summary>
        /// The maximum number of VMs that can attach to the disk at the same time. Value greater than one indicates a disk that can be mounted on multiple VMs at the same time.
        /// </summary>
        [JsonPropertyName("maxShares")]
        public int MaxShares { get; set; }
        [JsonPropertyName("networkAccessPolicy")]
        public string NetworkAccessPolicy { get; set; }

        /// <summary>
        /// The Operating System type.
        /// </summary>
        [JsonPropertyName("osType")]
        public string OsType { get; set; }
        [JsonPropertyName("publicNetworkAccess")]
        public string PublicNetworkAccess { get; set; }

        /// <summary>
        /// Used for establishing the purchase context of any 3rd Party artifact through MarketPlace.
        /// </summary>
        [JsonPropertyName("purchasePlan")]
        public PurchasePlan PurchasePlan { get; set; }

        /// <summary>
        /// Contains the security related information for the resource.
        /// </summary>
        [JsonPropertyName("securityProfile")]
        public DiskSecurityProfile SecurityProfile { get; set; }

        /// <summary>
        /// List of supported capabilities persisted on the disk resource for VM use.
        /// </summary>
        [JsonPropertyName("supportedCapabilities")]
        public SupportedCapabilities SupportedCapabilities { get; set; }

        /// <summary>
        /// Indicates the OS on a disk supports hibernation.
        /// </summary>
        [JsonPropertyName("supportsHibernation")]
        public bool SupportsHibernation { get; set; }

        /// <summary>
        /// Performance tier of the disk (e.g, P4, S10) as described here: https://azure.microsoft.com/en-us/pricing/details/managed-disks/. Does not apply to Ultra disks.
        /// </summary>
        [JsonPropertyName("tier")]
        public string Tier { get; set; }
    }
}