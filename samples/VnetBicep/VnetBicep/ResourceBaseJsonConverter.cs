using AzureDesignStudio.AzureResources.Base;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace VnetBicep
{
    internal class ResourceBaseJsonConverter : JsonConverter<ResourceBase>
    {
        public override ResourceBase Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
            => throw new NotImplementedException();

        public override void Write(Utf8JsonWriter writer, ResourceBase value, JsonSerializerOptions options)
            => JsonSerializer.Serialize(writer, value, value.GetType(), options);
    }
}
