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
    [GeneratedCode("Microsoft.Json.Schema.ToDotNet", "1.1.3.0")]
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