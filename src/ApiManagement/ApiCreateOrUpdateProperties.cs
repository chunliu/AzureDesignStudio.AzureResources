// Licensed under the MIT License.  See LICENSE in the project root for license information.

using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using AzureDesignStudio.AzureResources.Base;

namespace AzureDesignStudio.AzureResources.ApiManagement
{
    /// <summary>
    /// API Create or Update Properties.
    /// </summary>
    [GeneratedCode("ArmTypeGenerator", "0.1.8.0")]
    public partial class ApiCreateOrUpdateProperties
    {
        /// <summary>
        /// Describes the revision of the API. If no value is provided, default revision 1 is created
        /// </summary>
        [JsonPropertyName("apiRevision")]
        public string ApiRevision { get; set; }

        /// <summary>
        /// Description of the API Revision.
        /// </summary>
        [JsonPropertyName("apiRevisionDescription")]
        public string ApiRevisionDescription { get; set; }

        /// <summary>
        /// Type of API to create. 
        [JsonPropertyName("apiType")]
        public string ApiType { get; set; }

        /// <summary>
        /// Indicates the version identifier of the API if the API is versioned
        /// </summary>
        [JsonPropertyName("apiVersion")]
        public string ApiVersion { get; set; }

        /// <summary>
        /// Description of the API Version.
        /// </summary>
        [JsonPropertyName("apiVersionDescription")]
        public string ApiVersionDescription { get; set; }

        /// <summary>
        /// An API Version Set contains the common configuration for a set of API Versions relating 
        /// </summary>
        [JsonPropertyName("apiVersionSet")]
        public ApiVersionSetContractDetails ApiVersionSet { get; set; }

        /// <summary>
        /// A resource identifier for the related ApiVersionSet.
        /// </summary>
        [JsonPropertyName("apiVersionSetId")]
        public string ApiVersionSetId { get; set; }

        /// <summary>
        /// API Authentication Settings.
        /// </summary>
        [JsonPropertyName("authenticationSettings")]
        public AuthenticationSettingsContract AuthenticationSettings { get; set; }

        /// <summary>
        /// API contact information
        /// </summary>
        [JsonPropertyName("contact")]
        public ApiContactInformation Contact { get; set; }

        /// <summary>
        /// Description of the API. May include HTML formatting tags.
        /// </summary>
        [JsonPropertyName("description")]
        public string Description { get; set; }

        /// <summary>
        /// API name. Must be 1 to 300 characters long.
        /// </summary>
        [JsonPropertyName("displayName")]
        public string DisplayName { get; set; }

        /// <summary>
        /// Format of the Content in which the API is getting imported.
        /// </summary>
        [JsonPropertyName("format")]
        public string Format { get; set; }

        /// <summary>
        /// Indicates if API revision is current api revision.
        /// </summary>
        [JsonPropertyName("isCurrent")]
        public bool IsCurrent { get; set; }

        /// <summary>
        /// API license information
        /// </summary>
        [JsonPropertyName("license")]
        public ApiLicenseInformation License { get; set; }

        /// <summary>
        /// Relative URL uniquely identifying this API and all of its resource paths within the API Management service instance. It is appended to the API endpoint base URL specified during the service instance creation to form a public URL for this API.
        /// </summary>
        [Required]
        [JsonPropertyName("path")]
        public string Path { get; set; }

        /// <summary>
        /// Describes on which protocols the operations in this API can be invoked.
        /// </summary>
        [JsonPropertyName("protocols")]
        public IList<string> Protocols { get; set; }

        /// <summary>
        /// Absolute URL of the backend service implementing this API. Cannot be more than 2000 characters long.
        /// </summary>
        [JsonPropertyName("serviceUrl")]
        public string ServiceUrl { get; set; }

        /// <summary>
        /// API identifier of the source API.
        /// </summary>
        [JsonPropertyName("sourceApiId")]
        public string SourceApiId { get; set; }

        /// <summary>
        /// Subscription key parameter names details.
        /// </summary>
        [JsonPropertyName("subscriptionKeyParameterNames")]
        public SubscriptionKeyParameterNamesContract SubscriptionKeyParameterNames { get; set; }

        /// <summary>
        /// Specifies whether an API or Product subscription is required for accessing the API.
        /// </summary>
        [JsonPropertyName("subscriptionRequired")]
        public bool SubscriptionRequired { get; set; }

        /// <summary>
        ///  A URL to the Terms of Service for the API. MUST be in the format of a URL.
        /// </summary>
        [JsonPropertyName("termsOfServiceUrl")]
        public string TermsOfServiceUrl { get; set; }

        /// <summary>
        /// Type of API.
        /// </summary>
        [JsonPropertyName("type")]
        public string Type { get; set; }

        /// <summary>
        /// Content value when Importing an API.
        /// </summary>
        [JsonPropertyName("value")]
        public string Value { get; set; }

        /// <summary>
        /// Criteria to limit import of WSDL to a subset of the document.
        /// </summary>
        [JsonPropertyName("wsdlSelector")]
        public ApiCreateOrUpdatePropertiesWsdlSelector WsdlSelector { get; set; }
    }
}