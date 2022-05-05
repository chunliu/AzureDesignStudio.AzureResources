// Licensed under the MIT License.  See LICENSE in the project root for license information.

using System;
using System.CodeDom.Compiler;
using System.Text.Json.Serialization;
using AzureDesignStudio.AzureResources.Base;

namespace AzureDesignStudio.AzureResources.Web
{
    /// <summary>
    /// The configuration settings of the storage of the tokens if blob storage is used.
    /// </summary>
    [GeneratedCode("ArmTypeGenerator", "0.1.8.0")]
    public partial class BlobStorageTokenStore
    {
        /// <summary>
        /// The name of the app setting containing the SAS URL of the blob storage containing the tokens.
        /// </summary>
        [JsonPropertyName("sasUrlSettingName")]
        public string SasUrlSettingName { get; set; }
    }
}