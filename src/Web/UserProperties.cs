using System;
using System.CodeDom.Compiler;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using AzureDesignStudio.AzureResources.Base;

namespace AzureDesignStudio.AzureResources.Web
{
    /// <summary>
    /// User resource specific properties
    /// </summary>
    [GeneratedCode("Microsoft.Json.Schema.ToDotNet", "1.1.3.0")]
    public partial class UserProperties
    {
        /// <summary>
        /// Password used for publishing.
        /// </summary>
        [JsonPropertyName("publishingPassword")]
        public string PublishingPassword { get; set; }

        /// <summary>
        /// Password hash used for publishing.
        /// </summary>
        [JsonPropertyName("publishingPasswordHash")]
        public string PublishingPasswordHash { get; set; }

        /// <summary>
        /// Password hash salt used for publishing.
        /// </summary>
        [JsonPropertyName("publishingPasswordHashSalt")]
        public string PublishingPasswordHashSalt { get; set; }

        /// <summary>
        /// Username used for publishing.
        /// </summary>
        [Required]
        [JsonPropertyName("publishingUserName")]
        public string PublishingUserName { get; set; }

        /// <summary>
        /// Url of SCM site.
        /// </summary>
        [JsonPropertyName("scmUri")]
        public string ScmUri { get; set; }
    }
}