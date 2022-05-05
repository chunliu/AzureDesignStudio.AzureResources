// Licensed under the MIT License.  See LICENSE in the project root for license information.

using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using AzureDesignStudio.AzureResources.Base;

namespace AzureDesignStudio.AzureResources.Storage
{
    /// <summary>
    /// The properties of the file share.
    /// </summary>
    [GeneratedCode("ArmTypeGenerator", "0.1.8.0")]
    public partial class FileShareProperties
    {
        /// <summary>
        /// Access tier for specific share. GpV2 account can choose between TransactionOptimized (default), Hot, and Cool. FileStorage account can choose Premium.
        /// </summary>
        [JsonPropertyName("accessTier")]
        public string AccessTier { get; set; }

        /// <summary>
        /// The authentication protocol that is used for the file share. Can only be specified when creating a share.
        /// </summary>
        [JsonPropertyName("enabledProtocols")]
        public string EnabledProtocols { get; set; }

        /// <summary>
        /// A name-value pair to associate with the share as metadata.
        /// </summary>
        [JsonPropertyName("metadata")]
        public IDictionary<string, string> Metadata { get; set; }

        /// <summary>
        /// The property is for NFS share only. The default is NoRootSquash.
        /// </summary>
        [JsonPropertyName("rootSquash")]
        public string RootSquash { get; set; }

        /// <summary>
        /// The maximum size of the share, in gigabytes. Must be greater than 0, and less than or equal to 5TB (5120). For Large File Shares, the maximum size is 102400.
        /// </summary>
        [JsonPropertyName("shareQuota")]
        public int ShareQuota { get; set; }

        /// <summary>
        /// List of stored access policies specified on the share.
        /// </summary>
        [JsonPropertyName("signedIdentifiers")]
        public IList<SignedIdentifier> SignedIdentifiers { get; set; }
    }
}