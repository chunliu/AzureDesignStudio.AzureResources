// Licensed under the MIT License.  See LICENSE in the project root for license information.

using System;
using System.CodeDom.Compiler;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using AzureDesignStudio.AzureResources.Base;

namespace AzureDesignStudio.AzureResources.Storage
{
    /// <summary>
    /// Settings for Azure Files identity based authentication.
    /// </summary>
    [GeneratedCode("ArmTypeGenerator", "0.1.8.0")]
    public partial class AzureFilesIdentityBasedAuthentication
    {
        /// <summary>
        /// Settings properties for Active Directory (AD).
        /// </summary>
        [JsonPropertyName("activeDirectoryProperties")]
        public ActiveDirectoryProperties ActiveDirectoryProperties { get; set; }

        /// <summary>
        /// Default share permission for users using Kerberos authentication if RBAC role is not assigned.
        /// </summary>
        [JsonPropertyName("defaultSharePermission")]
        public string DefaultSharePermission { get; set; }

        /// <summary>
        /// Indicates the directory service used.
        /// </summary>
        [Required]
        [JsonPropertyName("directoryServiceOptions")]
        public string DirectoryServiceOptions { get; set; }
    }
}