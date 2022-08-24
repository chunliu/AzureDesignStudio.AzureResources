// Licensed under the MIT License.  See LICENSE in the project root for license information.

using System;
using System.CodeDom.Compiler;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using AzureDesignStudio.AzureResources.Base;

namespace AzureDesignStudio.AzureResources.Compute
{
    /// <summary>
    /// Indicates the error details if the background copy of a resource created via the CopyStart operation fails.
    /// </summary>
    [GeneratedCode("ArmTypeGenerator", "0.1.8.0")]
    public partial class CopyCompletionError
    {
        /// <summary>
        /// Indicates the error code if the background copy of a resource created via the CopyStart operation fails.
        /// </summary>
        [Required]
        [JsonPropertyName("errorCode")]
        public string ErrorCode { get; set; }

        /// <summary>
        /// Indicates the error message if the background copy of a resource created via the CopyStart operation fails.
        /// </summary>
        [Required]
        [JsonPropertyName("errorMessage")]
        public string ErrorMessage { get; set; }
    }
}