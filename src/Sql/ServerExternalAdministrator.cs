// Licensed under the MIT License.  See LICENSE in the project root for license information.

using System;
using System.CodeDom.Compiler;
using System.Text.Json.Serialization;
using AzureDesignStudio.AzureResources.Base;

namespace AzureDesignStudio.AzureResources.Sql
{
    /// <summary>
    /// Properties of a active directory administrator.
    /// </summary>
    [GeneratedCode("ArmTypeGenerator", "0.1.8.0")]
    public partial class ServerExternalAdministrator
    {
        /// <summary>
        /// Type of the sever administrator.
        /// </summary>
        [JsonPropertyName("administratorType")]
        public string AdministratorType { get; set; }

        /// <summary>
        /// Azure Active Directory only Authentication enabled.
        /// </summary>
        [JsonPropertyName("azureADOnlyAuthentication")]
        public bool AzureADOnlyAuthentication { get; set; }

        /// <summary>
        /// Login name of the server administrator.
        /// </summary>
        [JsonPropertyName("login")]
        public string Login { get; set; }

        /// <summary>
        /// Principal Type of the sever administrator.
        /// </summary>
        [JsonPropertyName("principalType")]
        public string PrincipalType { get; set; }

        /// <summary>
        /// SID (object ID) of the server administrator.
        /// </summary>
        [JsonPropertyName("sid")]
        public string Sid { get; set; }

        /// <summary>
        /// Tenant ID of the administrator.
        /// </summary>
        [JsonPropertyName("tenantId")]
        public string TenantId { get; set; }
    }
}