using Azure.Core;
using Azure.Identity;
using AzureDesignStudio.AzureResources.Network;
using System.Text.Encodings.Web;
using System.Text.Json;
using System.Text.Json.Serialization;

var credential = new AzureCliCredential();
var tokenReqContext = new TokenRequestContext(new string[] { "https://management.azure.com/.default" });
var accessToken = credential.GetToken(tokenReqContext);

var httpClient = new HttpClient();
httpClient.BaseAddress = new Uri("https://management.azure.com/");

var subscriptionId = "<Subscription Id>";
var resourceGroupName = "<Resource group name>";
var virtualNetworkName = "<Vnet name>";

var vnet = new VirtualNetworks()
{
    Location = "eastus",
    Properties = new()
    {
        AddressSpace = new()
        {
            AddressPrefixes = new List<string> { "10.0.0.0/16" }
        }
    }
};

var vnetContent = JsonSerializer.Serialize(vnet,
    new JsonSerializerOptions(JsonSerializerDefaults.Web)
    {
        DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingDefault,
        Encoder = JavaScriptEncoder.UnsafeRelaxedJsonEscaping,
        WriteIndented = true,
        IgnoreReadOnlyProperties = true
    });

var request = new HttpRequestMessage()
{
    Method = HttpMethod.Put,
    RequestUri = new Uri(
        $"/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/virtualNetworks/{virtualNetworkName}?api-version={vnet.ApiVersion}",
        UriKind.Relative),
    Content = new StringContent(vnetContent, System.Text.Encoding.UTF8, "application/json"),
};

request.Headers.Add("Authorization", $"Bearer {accessToken.Token}");

var response = await httpClient.SendAsync(request);

Console.WriteLine($"{(int)response.StatusCode} - {response.StatusCode}");
