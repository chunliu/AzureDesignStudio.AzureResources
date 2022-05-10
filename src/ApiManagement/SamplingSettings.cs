// Licensed under the MIT License.  See LICENSE in the project root for license information.

using System;
using System.CodeDom.Compiler;
using System.Text.Json.Serialization;
using AzureDesignStudio.AzureResources.Base;

namespace AzureDesignStudio.AzureResources.ApiManagement
{
    /// <summary>
    /// Sampling settings for Diagnostic.
    /// </summary>
    [GeneratedCode("ArmTypeGenerator", "0.1.8.0")]
    public partial class SamplingSettings
    {
        /// <summary>
        /// Rate of sampling for fixed-rate sampling.
        /// </summary>
        [JsonPropertyName("percentage")]
        public double Percentage { get; set; }

        /// <summary>
        /// Sampling type.
        /// </summary>
        [JsonPropertyName("samplingType")]
        public string SamplingType { get; set; }
    }
}