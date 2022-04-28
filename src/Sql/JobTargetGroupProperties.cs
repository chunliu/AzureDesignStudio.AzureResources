using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using AzureDesignStudio.AzureResources.Base;

namespace AzureDesignStudio.AzureResources.Sql
{
    /// <summary>
    /// Properties of job target group.
    /// </summary>
    [GeneratedCode("Microsoft.Json.Schema.ToDotNet", "1.1.3.0")]
    public partial class JobTargetGroupProperties
    {
        /// <summary>
        /// Members of the target group.
        /// </summary>
        [Required]
        [JsonPropertyName("members")]
        public IList<JobTarget> Members { get; set; }
    }
}