using System;
using System.CodeDom.Compiler;
using System.Text.Json.Serialization;
using AzureDesignStudio.AzureResources.Base;

namespace AzureDesignStudio.AzureResources.Web
{
    [GeneratedCode("Microsoft.Json.Schema.ToDotNet", "1.1.3.0")]
    public partial class ArcConfiguration
    {
        [JsonPropertyName("artifactsStorageType")]
        public string ArtifactsStorageType { get; set; }
        [JsonPropertyName("artifactStorageAccessMode")]
        public string ArtifactStorageAccessMode { get; set; }
        [JsonPropertyName("artifactStorageClassName")]
        public string ArtifactStorageClassName { get; set; }
        [JsonPropertyName("artifactStorageMountPath")]
        public string ArtifactStorageMountPath { get; set; }
        [JsonPropertyName("artifactStorageNodeName")]
        public string ArtifactStorageNodeName { get; set; }
        [JsonPropertyName("frontEndServiceConfiguration")]
        public FrontEndConfiguration FrontEndServiceConfiguration { get; set; }
        [JsonPropertyName("kubeConfig")]
        public string KubeConfig { get; set; }
    }
}