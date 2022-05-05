// Licensed under the MIT License.  See LICENSE in the project root for license information.

using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using AzureDesignStudio.AzureResources.Base;

namespace AzureDesignStudio.AzureResources.Network
{
    /// <summary>
    /// Properties of the application gateway.
    /// </summary>
    [GeneratedCode("ArmTypeGenerator", "0.1.8.0")]
    public partial class ApplicationGatewayPropertiesFormat
    {
        /// <summary>
        /// SKU of the application gateway resource.
        /// </summary>
        [JsonPropertyName("sku")]
        public ApplicationGatewaySku Sku { get; set; }

        /// <summary>
        /// SSL policy of the application gateway resource.
        /// </summary>
        [JsonPropertyName("sslPolicy")]
        public ApplicationGatewaySslPolicy SslPolicy { get; set; }

        /// <summary>
        /// Subnets of the application gateway resource. For default limits, see [Application Gateway limits](https://docs.microsoft.com/azure/azure-subscription-service-limits#application-gateway-limits).
        /// </summary>
        [JsonPropertyName("gatewayIPConfigurations")]
        public IList<ApplicationGatewayIPConfiguration> GatewayIPConfigurations { get; set; }

        /// <summary>
        /// Authentication certificates of the application gateway resource. For default limits, see [Application Gateway limits](https://docs.microsoft.com/azure/azure-subscription-service-limits#application-gateway-limits).
        /// </summary>
        [JsonPropertyName("authenticationCertificates")]
        public IList<ApplicationGatewayAuthenticationCertificate> AuthenticationCertificates { get; set; }

        /// <summary>
        /// Trusted Root certificates of the application gateway resource. For default limits, see [Application Gateway limits](https://docs.microsoft.com/azure/azure-subscription-service-limits#application-gateway-limits).
        /// </summary>
        [JsonPropertyName("trustedRootCertificates")]
        public IList<ApplicationGatewayTrustedRootCertificate> TrustedRootCertificates { get; set; }

        /// <summary>
        /// Trusted client certificates of the application gateway resource. For default limits, see [Application Gateway limits](https://docs.microsoft.com/azure/azure-subscription-service-limits#application-gateway-limits).
        /// </summary>
        [JsonPropertyName("trustedClientCertificates")]
        public IList<ApplicationGatewayTrustedClientCertificate> TrustedClientCertificates { get; set; }

        /// <summary>
        /// SSL certificates of the application gateway resource. For default limits, see [Application Gateway limits](https://docs.microsoft.com/azure/azure-subscription-service-limits#application-gateway-limits).
        /// </summary>
        [JsonPropertyName("sslCertificates")]
        public IList<ApplicationGatewaySslCertificate> SslCertificates { get; set; }

        /// <summary>
        /// Frontend IP addresses of the application gateway resource. For default limits, see [Application Gateway limits](https://docs.microsoft.com/azure/azure-subscription-service-limits#application-gateway-limits).
        /// </summary>
        [JsonPropertyName("frontendIPConfigurations")]
        public IList<ApplicationGatewayFrontendIPConfiguration> FrontendIPConfigurations { get; set; }

        /// <summary>
        /// Frontend ports of the application gateway resource. For default limits, see [Application Gateway limits](https://docs.microsoft.com/azure/azure-subscription-service-limits#application-gateway-limits).
        /// </summary>
        [JsonPropertyName("frontendPorts")]
        public IList<ApplicationGatewayFrontendPort> FrontendPorts { get; set; }

        /// <summary>
        /// Probes of the application gateway resource.
        /// </summary>
        [JsonPropertyName("probes")]
        public IList<ApplicationGatewayProbe> Probes { get; set; }

        /// <summary>
        /// Backend address pool of the application gateway resource. For default limits, see [Application Gateway limits](https://docs.microsoft.com/azure/azure-subscription-service-limits#application-gateway-limits).
        /// </summary>
        [JsonPropertyName("backendAddressPools")]
        public IList<ApplicationGatewayBackendAddressPool> BackendAddressPools { get; set; }

        /// <summary>
        /// Backend http settings of the application gateway resource. For default limits, see [Application Gateway limits](https://docs.microsoft.com/azure/azure-subscription-service-limits#application-gateway-limits).
        /// </summary>
        [JsonPropertyName("backendHttpSettingsCollection")]
        public IList<ApplicationGatewayBackendHttpSettings> BackendHttpSettingsCollection { get; set; }

        /// <summary>
        /// Http listeners of the application gateway resource. For default limits, see [Application Gateway limits](https://docs.microsoft.com/azure/azure-subscription-service-limits#application-gateway-limits).
        /// </summary>
        [JsonPropertyName("httpListeners")]
        public IList<ApplicationGatewayHttpListener> HttpListeners { get; set; }

        /// <summary>
        /// SSL profiles of the application gateway resource. For default limits, see [Application Gateway limits](https://docs.microsoft.com/azure/azure-subscription-service-limits#application-gateway-limits).
        /// </summary>
        [JsonPropertyName("sslProfiles")]
        public IList<ApplicationGatewaySslProfile> SslProfiles { get; set; }

        /// <summary>
        /// URL path map of the application gateway resource. For default limits, see [Application Gateway limits](https://docs.microsoft.com/azure/azure-subscription-service-limits#application-gateway-limits).
        /// </summary>
        [JsonPropertyName("urlPathMaps")]
        public IList<ApplicationGatewayUrlPathMap> UrlPathMaps { get; set; }

        /// <summary>
        /// Request routing rules of the application gateway resource.
        /// </summary>
        [JsonPropertyName("requestRoutingRules")]
        public IList<ApplicationGatewayRequestRoutingRule> RequestRoutingRules { get; set; }

        /// <summary>
        /// Rewrite rules for the application gateway resource.
        /// </summary>
        [JsonPropertyName("rewriteRuleSets")]
        public IList<ApplicationGatewayRewriteRuleSet> RewriteRuleSets { get; set; }

        /// <summary>
        /// Redirect configurations of the application gateway resource. For default limits, see [Application Gateway limits](https://docs.microsoft.com/azure/azure-subscription-service-limits#application-gateway-limits).
        /// </summary>
        [JsonPropertyName("redirectConfigurations")]
        public IList<ApplicationGatewayRedirectConfiguration> RedirectConfigurations { get; set; }

        /// <summary>
        /// Web application firewall configuration.
        /// </summary>
        [JsonPropertyName("webApplicationFirewallConfiguration")]
        public ApplicationGatewayWebApplicationFirewallConfiguration WebApplicationFirewallConfiguration { get; set; }

        /// <summary>
        /// Reference to the FirewallPolicy resource.
        /// </summary>
        [JsonPropertyName("firewallPolicy")]
        public SubResource FirewallPolicy { get; set; }

        /// <summary>
        /// Whether HTTP2 is enabled on the application gateway resource.
        /// </summary>
        [JsonPropertyName("enableHttp2")]
        public bool EnableHttp2 { get; set; }

        /// <summary>
        /// Whether FIPS is enabled on the application gateway resource.
        /// </summary>
        [JsonPropertyName("enableFips")]
        public bool EnableFips { get; set; }

        /// <summary>
        /// Autoscale Configuration.
        /// </summary>
        [JsonPropertyName("autoscaleConfiguration")]
        public ApplicationGatewayAutoscaleConfiguration AutoscaleConfiguration { get; set; }

        /// <summary>
        /// PrivateLink configurations on application gateway.
        /// </summary>
        [JsonPropertyName("privateLinkConfigurations")]
        public IList<ApplicationGatewayPrivateLinkConfiguration> PrivateLinkConfigurations { get; set; }

        /// <summary>
        /// Custom error configurations of the application gateway resource.
        /// </summary>
        [JsonPropertyName("customErrorConfigurations")]
        public IList<ApplicationGatewayCustomError> CustomErrorConfigurations { get; set; }

        /// <summary>
        /// If true, associates a firewall policy with an application gateway regardless whether the policy differs from the WAF Config.
        /// </summary>
        [JsonPropertyName("forceFirewallPolicyAssociation")]
        public bool ForceFirewallPolicyAssociation { get; set; }
    }
}