// Licensed under the MIT License.  See LICENSE in the project root for license information.

using System;
using System.CodeDom.Compiler;
using System.Text.Json.Serialization;
using AzureDesignStudio.AzureResources.Base;

namespace AzureDesignStudio.AzureResources.Web
{
    /// <summary>
    /// The configuration settings of the Twitter provider.
    /// </summary>
    [GeneratedCode("ArmTypeGenerator", "0.1.8.0")]
    public partial class Twitter
    {
        /// <summary>
        /// <code>false</code> if the Twitter provider should not be enabled despite the set registration; otherwise, <code>true</code>.
        /// </summary>
        [JsonPropertyName("enabled")]
        public bool Enabled { get; set; }

        /// <summary>
        /// The configuration settings of the app registration for the Twitter provider.
        /// </summary>
        [JsonPropertyName("registration")]
        public TwitterRegistration Registration { get; set; }
    }
}