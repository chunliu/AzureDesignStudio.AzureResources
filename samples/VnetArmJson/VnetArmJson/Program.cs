using AzureDesignStudio.AzureResources.Base;
using AzureDesignStudio.AzureResources.Network;
using System.Text.Encodings.Web;
using System.Text.Json;
using System.Text.Json.Serialization;
using VnetArmJson;

VirtualNetworks vnet = new()
{
    Name = "Hello-vnet",
    Location = "eastus",
    Properties = new()
    {
        AddressSpace = new()
        {
            AddressPrefixes = new List<string> { "10.0.0.0/16" }
        }
    }
};

VirtualNetworksSubnets subnet = new()
{
    Name = $"{vnet.Name}/subnet1",
    Properties = new()
    {
        AddressPrefix = "10.0.0.0/24"
    },
};

DeploymentTemplate deploymentTemplate = new()
{
    Schema = "https://schema.management.azure.com/schemas/2019-04-01/deploymentTemplate.json#",
    ContentVersion = "1.0.0.0",
    Resources = new List<ResourceBase> { vnet, subnet }
};

var template = JsonSerializer.Serialize(deploymentTemplate,
    new JsonSerializerOptions(JsonSerializerDefaults.Web)
    {
        DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingDefault,
        Encoder = JavaScriptEncoder.UnsafeRelaxedJsonEscaping,
        WriteIndented = true,
        Converters = { new ResourceBaseJsonConverter() }
    });

Console.Write(template);
