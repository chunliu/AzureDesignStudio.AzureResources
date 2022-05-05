// Licensed under the MIT License.  See LICENSE in the project root for license information.

using System;
using System.CodeDom.Compiler;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using AzureDesignStudio.AzureResources.Base;

namespace AzureDesignStudio.AzureResources.Storage
{
    /// <summary>
    /// Object to define the number of days after creation.
    /// </summary>
    [GeneratedCode("ArmTypeGenerator", "0.1.8.0")]
    public partial class DateAfterCreation
    {
        /// <summary>
        /// Value indicating the age in days after creation
        /// </summary>
        [Required]
        [JsonPropertyName("daysAfterCreationGreaterThan")]
        public double DaysAfterCreationGreaterThan { get; set; }
    }
}