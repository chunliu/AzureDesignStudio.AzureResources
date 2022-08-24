// Licensed under the MIT License.  See LICENSE in the project root for license information.

using System;
using System.CodeDom.Compiler;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using AzureDesignStudio.AzureResources.Base;

namespace AzureDesignStudio.AzureResources.Compute
{
    /// <summary>
    /// Snapshot resource properties.
    /// </summary>
    [GeneratedCode("ArmTypeGenerator", "0.1.8.0")]
    public partial class SnapshotProperties
    {
        /// <summary>
        /// Percentage complete for the background copy when a resource is created via the CopyStart operation.
        /// </summary>
        [JsonPropertyName("completionPercent")]
        public double CompletionPercent { get; set; }

        /// <summary>
        /// Indicates the error details if the background copy of a resource created via the CopyStart operation fails.
        /// </summary>
        [JsonPropertyName("copyCompletionError")]
        public CopyCompletionError CopyCompletionError { get; set; }

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
        /// If creationData.createOption is Empty, this field is mandatory and it indicates the size of the disk to create. If this field is present for updates or creation with other options, it indicates a resize. Resizes are only allowed if the disk is not attached to a running VM, and can only increase the disk's size.
        /// </summary>
        [JsonPropertyName("diskSizeGB")]
        public int DiskSizeGB { get; set; }

        /// <summary>
        /// The state of the snapshot.
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
        /// Whether a snapshot is incremental. Incremental snapshots on the same disk occupy less space than full snapshots and can be diffed.
        /// </summary>
        [JsonPropertyName("incremental")]
        public bool Incremental { get; set; }
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
        /// Indicates the OS on a snapshot supports hibernation.
        /// </summary>
        [JsonPropertyName("supportsHibernation")]
        public bool SupportsHibernation { get; set; }
    }
}