// Licensed under the MIT License.  See LICENSE in the project root for license information.

using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using AzureDesignStudio.AzureResources.Base;

namespace AzureDesignStudio.AzureResources.Compute
{
    /// <summary>
    /// Describes a cloud service extension profile.
    /// </summary>
    [GeneratedCode("ArmTypeGenerator", "0.1.8.0")]
    public partial class CloudServiceExtensionProfile
    {
        /// <summary>
        /// List of extensions for the cloud service.
        /// </summary>
        [JsonPropertyName("extensions")]
        public IList<Extension> Extensions { get; set; }
    }
}