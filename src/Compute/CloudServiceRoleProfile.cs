// Licensed under the MIT License.  See LICENSE in the project root for license information.

using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using AzureDesignStudio.AzureResources.Base;

namespace AzureDesignStudio.AzureResources.Compute
{
    /// <summary>
    /// Describes the role profile for the cloud service.
    /// </summary>
    [GeneratedCode("ArmTypeGenerator", "0.1.8.0")]
    public partial class CloudServiceRoleProfile
    {
        /// <summary>
        /// List of roles for the cloud service.
        /// </summary>
        [JsonPropertyName("roles")]
        public IList<CloudServiceRoleProfileProperties> Roles { get; set; }
    }
}