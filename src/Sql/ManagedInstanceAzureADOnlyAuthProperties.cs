// Licensed under the MIT License.  See LICENSE in the project root for license information.

using System;
using System.CodeDom.Compiler;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using AzureDesignStudio.AzureResources.Base;

namespace AzureDesignStudio.AzureResources.Sql
{
    /// <summary>
    /// Properties of a active directory only authentication for Managed Instance.
    /// </summary>
    [GeneratedCode("ArmTypeGenerator", "0.1.8.0")]
    public partial class ManagedInstanceAzureADOnlyAuthProperties
    {
        /// <summary>
        /// Azure Active Directory only Authentication enabled.
        /// </summary>
        [Required]
        [JsonPropertyName("azureADOnlyAuthentication")]
        public bool AzureADOnlyAuthentication { get; set; }
    }
}