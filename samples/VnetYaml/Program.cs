using AzureDesignStudio.AzureResources.Base;
using AzureDesignStudio.AzureResources.Network;
using Shared;
using System.Text.Encodings.Web;
using System.Text.Json;
using System.Text.Json.Serialization;
using YamlDotNet.Serialization;
using YamlDotNet.Serialization.NamingConventions;

var deserializer = new DeserializerBuilder()
    .WithNamingConvention(CamelCaseNamingConvention.Instance)
    .Build();

var template = deserializer.Deserialize<IDictionary<string, dynamic>>(File.ReadAllText("Vnet.yaml"));

var resources = template["resources"];

DeploymentTemplate deploymentTemplate = new()
{
    Schema = template["schema"],
    ContentVersion = template["contentVersion"],
    Resources = new List<ResourceBase>
    {
        new VirtualNetworks()
        {
            Name = resources[0]["name"],
            Location = resources[0]["location"],
            Properties = new()
            {
                AddressSpace = new()
                {
                    AddressPrefixes = new List<string>
                    {
                        resources[0]["properties"]["addressSpace"]["addressPrefixes"][0]
                    }
                }
            }
        },
        new VirtualNetworksSubnets()
        {
            Name = resources[1]["name"],
            Properties = new()
            {
                AddressPrefix = resources[1]["properties"]["addressPrefix"]
            }
        }
    }
};

var arm = JsonSerializer.Serialize(deploymentTemplate,
    new JsonSerializerOptions(JsonSerializerDefaults.Web)
    {
        DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingDefault,
        Encoder = JavaScriptEncoder.UnsafeRelaxedJsonEscaping,
        WriteIndented = true,
        Converters = { new ResourceBaseJsonConverter() }
    });

Console.WriteLine(arm);
