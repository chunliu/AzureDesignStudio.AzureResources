// Licensed under the MIT License.  See LICENSE in the project root for license information.

using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using AzureDesignStudio.AzureResources.Base;

namespace AzureDesignStudio.AzureResources.Sql
{
    /// <summary>
    /// Properties of a security alert policy.
    /// </summary>
    [GeneratedCode("ArmTypeGenerator", "0.1.8.0")]
    public partial class SecurityAlertPolicyProperties
    {
        /// <summary>
        /// Specifies an array of alerts that are disabled. Allowed values are: Sql_Injection, Sql_Injection_Vulnerability, Access_Anomaly, Data_Exfiltration, Unsafe_Action, Brute_Force
        /// </summary>
        [JsonPropertyName("disabledAlerts")]
        public IList<string> DisabledAlerts { get; set; }

        /// <summary>
        /// Specifies that the alert is sent to the account administrators.
        /// </summary>
        [JsonPropertyName("emailAccountAdmins")]
        public bool EmailAccountAdmins { get; set; }

        /// <summary>
        /// Specifies an array of e-mail addresses to which the alert is sent.
        /// </summary>
        [JsonPropertyName("emailAddresses")]
        public IList<string> EmailAddresses { get; set; }

        /// <summary>
        /// Specifies the number of days to keep in the Threat Detection audit logs.
        /// </summary>
        [JsonPropertyName("retentionDays")]
        public int RetentionDays { get; set; }

        /// <summary>
        /// Specifies the state of the policy, whether it is enabled or disabled or a policy has not been applied yet on the specific database.
        /// </summary>
        [Required]
        [JsonPropertyName("state")]
        public string State { get; set; }

        /// <summary>
        /// Specifies the identifier key of the Threat Detection audit storage account.
        /// </summary>
        [JsonPropertyName("storageAccountAccessKey")]
        public string StorageAccountAccessKey { get; set; }

        /// <summary>
        /// Specifies the blob storage endpoint (e.g. https://MyAccount.blob.core.windows.net). This blob storage will hold all Threat Detection audit logs.
        /// </summary>
        [JsonPropertyName("storageEndpoint")]
        public string StorageEndpoint { get; set; }
    }
}