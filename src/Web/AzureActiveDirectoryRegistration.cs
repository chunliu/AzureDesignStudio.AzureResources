// Licensed under the MIT License.  See LICENSE in the project root for license information.

using System;
using System.CodeDom.Compiler;
using System.Text.Json.Serialization;
using AzureDesignStudio.AzureResources.Base;

namespace AzureDesignStudio.AzureResources.Web
{
    /// <summary>
    /// The configuration settings of the Azure Active Directory app registration.
    /// </summary>
    [GeneratedCode("ArmTypeGenerator", "0.1.8.0")]
    public partial class AzureActiveDirectoryRegistration
    {
        /// <summary>
        /// The Client ID of this relying party application, known as the client_id.
        [JsonPropertyName("clientId")]
        public string ClientId { get; set; }

        /// <summary>
        /// An alternative to the client secret thumbprint, that is the issuer of a certificate used for signing purposes. This property acts as
        [JsonPropertyName("clientSecretCertificateIssuer")]
        public string ClientSecretCertificateIssuer { get; set; }

        /// <summary>
        /// An alternative to the client secret thumbprint, that is the subject alternative name of a certificate used for signing purposes. This property acts as
        [JsonPropertyName("clientSecretCertificateSubjectAlternativeName")]
        public string ClientSecretCertificateSubjectAlternativeName { get; set; }

        /// <summary>
        /// An alternative to the client secret, that is the thumbprint of a certificate used for signing purposes. This property acts as
        [JsonPropertyName("clientSecretCertificateThumbprint")]
        public string ClientSecretCertificateThumbprint { get; set; }

        /// <summary>
        /// The app setting name that contains the client secret of the relying party application.
        /// </summary>
        [JsonPropertyName("clientSecretSettingName")]
        public string ClientSecretSettingName { get; set; }

        /// <summary>
        /// The OpenID Connect Issuer URI that represents the entity which issues access tokens for this application.
        [JsonPropertyName("openIdIssuer")]
        public string OpenIdIssuer { get; set; }
    }
}