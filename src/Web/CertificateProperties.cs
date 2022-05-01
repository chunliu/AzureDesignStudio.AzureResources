using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using AzureDesignStudio.AzureResources.Base;

namespace AzureDesignStudio.AzureResources.Web
{
    /// <summary>
    /// Certificate resource specific properties
    /// </summary>
    [GeneratedCode("Microsoft.Json.Schema.ToDotNet", "1.1.3.0")]
    public partial class CertificateProperties
    {
        /// <summary>
        /// CNAME of the certificate to be issued via free certificate
        /// </summary>
        [JsonPropertyName("canonicalName")]
        public string CanonicalName { get; set; }

        /// <summary>
        /// Method of domain validation for free cert
        /// </summary>
        [JsonPropertyName("domainValidationMethod")]
        public string DomainValidationMethod { get; set; }

        /// <summary>
        /// Host names the certificate applies to.
        /// </summary>
        [JsonPropertyName("hostNames")]
        public IList<string> HostNames { get; set; }

        /// <summary>
        /// Key Vault Csm resource Id.
        /// </summary>
        [JsonPropertyName("keyVaultId")]
        public string KeyVaultId { get; set; }

        /// <summary>
        /// Key Vault secret name.
        /// </summary>
        [JsonPropertyName("keyVaultSecretName")]
        public string KeyVaultSecretName { get; set; }

        /// <summary>
        /// Certificate password.
        /// </summary>
        [JsonPropertyName("password")]
        public string Password { get; set; }

        /// <summary>
        /// Pfx blob.
        /// </summary>
        [JsonPropertyName("pfxBlob")]
        public string PfxBlob { get; set; }

        /// <summary>
        /// Resource ID of the associated App Service plan, formatted as: "/subscriptions/{subscriptionID}/resourceGroups/{groupName}/providers/Microsoft.Web/serverfarms/{appServicePlanName}".
        /// </summary>
        [JsonPropertyName("serverFarmId")]
        public string ServerFarmId { get; set; }
    }
}