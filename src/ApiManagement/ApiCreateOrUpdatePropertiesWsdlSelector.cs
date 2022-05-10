// Licensed under the MIT License.  See LICENSE in the project root for license information.

using System;
using System.CodeDom.Compiler;
using System.Text.Json.Serialization;
using AzureDesignStudio.AzureResources.Base;

namespace AzureDesignStudio.AzureResources.ApiManagement
{
    /// <summary>
    /// Criteria to limit import of WSDL to a subset of the document.
    /// </summary>
    [GeneratedCode("ArmTypeGenerator", "0.1.8.0")]
    public partial class ApiCreateOrUpdatePropertiesWsdlSelector
    {
        /// <summary>
        /// Name of endpoint(port) to import from WSDL
        /// </summary>
        [JsonPropertyName("wsdlEndpointName")]
        public string WsdlEndpointName { get; set; }

        /// <summary>
        /// Name of service to import from WSDL
        /// </summary>
        [JsonPropertyName("wsdlServiceName")]
        public string WsdlServiceName { get; set; }
    }
}