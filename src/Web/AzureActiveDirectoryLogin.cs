// Licensed under the MIT License.  See LICENSE in the project root for license information.

using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using AzureDesignStudio.AzureResources.Base;

namespace AzureDesignStudio.AzureResources.Web
{
    /// <summary>
    /// The configuration settings of the Azure Active Directory login flow.
    /// </summary>
    [GeneratedCode("ArmTypeGenerator", "0.1.8.0")]
    public partial class AzureActiveDirectoryLogin
    {
        /// <summary>
        /// <code>true</code> if the www-authenticate provider should be omitted from the request; otherwise, <code>false</code>.
        /// </summary>
        [JsonPropertyName("disableWWWAuthenticate")]
        public bool DisableWWWAuthenticate { get; set; }

        /// <summary>
        /// Login parameters to send to the OpenID Connect authorization endpoint when
        [JsonPropertyName("loginParameters")]
        public IList<string> LoginParameters { get; set; }
    }
}