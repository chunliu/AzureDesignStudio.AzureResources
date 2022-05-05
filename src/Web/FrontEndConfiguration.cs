// Licensed under the MIT License.  See LICENSE in the project root for license information.

using System;
using System.CodeDom.Compiler;
using System.Text.Json.Serialization;
using AzureDesignStudio.AzureResources.Base;

namespace AzureDesignStudio.AzureResources.Web
{
    [GeneratedCode("ArmTypeGenerator", "0.1.8.0")]
    public partial class FrontEndConfiguration
    {
        [JsonPropertyName("kind")]
        public string Kind { get; set; }
    }
}