// Licensed under the MIT License.  See LICENSE in the project root for license information.

using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using AzureDesignStudio.AzureResources.Base;

namespace AzureDesignStudio.AzureResources.Storage
{
    /// <summary>
    /// An object that defines the blob inventory rule.
    /// </summary>
    [GeneratedCode("ArmTypeGenerator", "0.1.8.0")]
    public partial class BlobInventoryPolicyDefinition
    {
        /// <summary>
        /// An object that defines the blob inventory rule filter conditions. For 'Blob' definition.objectType all filter properties are applicable, 'blobTypes' is required and others are optional. For 'Container' definition.objectType only prefixMatch is applicable and is optional.
        /// </summary>
        [JsonPropertyName("filters")]
        public BlobInventoryPolicyFilter Filters { get; set; }

        /// <summary>
        /// This is a required field, it specifies the format for the inventory files.
        /// </summary>
        [Required]
        [JsonPropertyName("format")]
        public string Format { get; set; }

        /// <summary>
        /// This is a required field. This field specifies the scope of the inventory created either at the blob or container level.
        /// </summary>
        [Required]
        [JsonPropertyName("objectType")]
        public string ObjectType { get; set; }

        /// <summary>
        /// This is a required field. This field is used to schedule an inventory formation.
        /// </summary>
        [Required]
        [JsonPropertyName("schedule")]
        public string Schedule { get; set; }

        /// <summary>
        /// This is a required field. This field specifies the fields and properties of the object to be included in the inventory. The Schema field value 'Name' is always required. The valid values for this field for the 'Blob' definition.objectType include 'Name, Creation-Time, Last-Modified, Content-Length, Content-MD5, BlobType, AccessTier, AccessTierChangeTime, AccessTierInferred, Tags, Expiry-Time, hdi_isfolder, Owner, Group, Permissions, Acl, Snapshot, VersionId, IsCurrentVersion, Metadata, LastAccessTime'. The valid values for 'Container' definition.objectType include 'Name, Last-Modified, Metadata, LeaseStatus, LeaseState, LeaseDuration, PublicAccess, HasImmutabilityPolicy, HasLegalHold'. Schema field values 'Expiry-Time, hdi_isfolder, Owner, Group, Permissions, Acl' are valid only for Hns enabled accounts.'Tags' field is only valid for non Hns accounts
        /// </summary>
        [Required]
        [JsonPropertyName("schemaFields")]
        public IList<string> SchemaFields { get; set; }
    }
}