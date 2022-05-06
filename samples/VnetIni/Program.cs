using AzureDesignStudio.AzureResources.Base;
using AzureDesignStudio.AzureResources.Network;
using Microsoft.Extensions.Configuration.Ini;
using Microsoft.Extensions.FileProviders;
using Shared;
using System.Text.Encodings.Web;
using System.Text.Json;
using System.Text.Json.Serialization;

var iniSource = new IniConfigurationSource()
{
    FileProvider = new PhysicalFileProvider(Directory.GetCurrentDirectory()),
    Path = "VnetIni.ini",
    Optional = true
};

var iniConfig = new IniConfigurationProvider(iniSource);
iniConfig.Load();

iniConfig.TryGet("vnet:name", out var vnetName);
iniConfig.TryGet("vnet:location", out var vnetLocation);
iniConfig.TryGet("vnet:addressPrefix", out var vnetAddressPrefix);

iniConfig.TryGet("subnet:name", out var subnetName);
iniConfig.TryGet("subnet:addressPrefix", out var subnetAddressPrefix);


VirtualNetworks vnet = new()
{
    Name = vnetName,
    Location = vnetLocation,
    Properties = new()
    {
        AddressSpace = new()
        {
            AddressPrefixes = new List<string> { vnetAddressPrefix }
        }
    }
};

VirtualNetworksSubnets subnet = new()
{
    Name = subnetName,
    Properties = new()
    {
        AddressPrefix = subnetAddressPrefix
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
